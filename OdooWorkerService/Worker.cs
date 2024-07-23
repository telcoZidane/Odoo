using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OdooWorkerService.DataAccess;
using OdooWorkerService.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OdooWorkerService
{
    public class Worker : BackgroundService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ILogger<Worker> _logger;
        private readonly IMapper mapper;

        public Worker(IServiceProvider serviceProvider, ILogger<Worker> logger, IMapper mapper)
        {
            this.serviceProvider = serviceProvider;
            _logger = logger;
            this.mapper = mapper;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                await SyncEmployees();

                await Task.Delay(50000, stoppingToken);
            }
        }

        private async Task SyncEmployees()
        {
            var odooEmployees = await GetAllEmployees("Odoo");
            var leociaEmployees = await GetAllEmployees("Leocia");

            //// Add or update employees in Leocia from Odoo
            foreach (var odooEmployee in odooEmployees)
            {
                var leociaEmployee = leociaEmployees.FirstOrDefault(e => e.IdOdoo == odooEmployee.IdOdoo);
                if (leociaEmployee == null)
                {
                    // Add new employee to Leocia
                    await CreateEmployee(mapper.Map<Core.Core.Entities.HrEmployee>(odooEmployee), "Leocia");
                }
                else if (leociaEmployee.WriteDate < odooEmployee.WriteDate)
                {
                    // Update existing employee in Leocia
                    await UpdateEmployee(mapper.Map<Core.Core.Entities.HrEmployee>(odooEmployee), leociaEmployee.Id, "Leocia");
                }
            }

            // Remove employees from Leocia that are no longer in Odoo
            foreach (var leociaEmployee in leociaEmployees)
            {
                if (!odooEmployees.Any(e => e.IdOdoo == leociaEmployee.IdOdoo))
                {
                    await DeleteEmployee(leociaEmployee.Id, "Leocia");
                }
            }

            // Add or update employees in Odoo from Leocia
            foreach (var leociaEmployee in leociaEmployees)
            {
                var odooEmployee = odooEmployees.FirstOrDefault(e => e.IdOdoo == leociaEmployee.IdOdoo);
                if (odooEmployee == null)
                {
                    // Add new employee to Odoo
                    await CreateEmployee(mapper.Map<Core.Core.Entities.HrEmployee>(leociaEmployee), "Odoo");
                
                }
                else if (odooEmployee.WriteDate < leociaEmployee.WriteDate)
                {
                    // Update existing employee in Odoo
                    await UpdateEmployee(mapper.Map<Core.Core.Entities.HrEmployee>(leociaEmployee), odooEmployee.IdOdoo, "Odoo");
                }
            }

            // Remove employees from Odoo that are no longer in Leocia
            foreach (var odooEmployee in odooEmployees)
            {
                if (!leociaEmployees.Any(e => e.IdOdoo == odooEmployee.IdOdoo))
                {
                    await DeleteEmployee(odooEmployee.IdOdoo, "Odoo");
                }
            }
        }

        public async Task CreateEmployee(Core.Core.Entities.HrEmployee hrEmployee, string direction)
        {
            if (direction == "Odoo")
            {
                var client = new RestClient("https://localhost:7081/api/HrEmployee");
                var request = new RestRequest("CreateEmp", Method.Post);
                request.AddHeader("Content-Type", "application/json-patch+json");
                request.AddHeader("accept", "*/*");
                request.AddJsonBody(hrEmployee);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("Employee added successfully.");
                    Console.WriteLine(response.Content);
                }
                else
                {
                    Console.WriteLine($"Error adding employee: {response.ErrorMessage}");
                }
            }
            else
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var leociaEmployeesContext = scope.ServiceProvider.GetRequiredService<LeociaEmployeesContext>();
                    var newEmployee = mapper.Map<HrEmployee>(hrEmployee);

                    newEmployee.Id = 0;

                    await leociaEmployeesContext.hrEmployees.AddAsync(newEmployee);
                    await leociaEmployeesContext.SaveChangesAsync();
                }
            }
        }

        public async Task DeleteEmployee(int id, string direction)
        {
            if (direction == "Odoo")
            {
                var client = new RestClient("https://localhost:7081/api/HrEmployee");
                var request = new RestRequest($"DeleteEmployee?id={id}", Method.Delete);
                request.AddHeader("accept", "*/*");

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("Employee deleted successfully from Odoo.");
                }
                else
                {
                    Console.WriteLine($"Error deleting employee from Odoo: {response.ErrorMessage}");
                }
            }
            else
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var leociaEmployeesContext = scope.ServiceProvider.GetRequiredService<LeociaEmployeesContext>();
                    var employee = await leociaEmployeesContext.hrEmployees.FirstOrDefaultAsync(x=> x.IdOdoo== id);
                    if (employee != null)
                    {
                        leociaEmployeesContext.hrEmployees.Remove(employee);
                        await leociaEmployeesContext.SaveChangesAsync();
                    }
                }
            }
        }

        public async Task UpdateEmployee(Core.Core.Entities.HrEmployee hrEmployee, int id, string direction)
        {
            if (direction == "Odoo")
            {
                var client = new RestClient("https://localhost:7081/api/HrEmployee");
                var request = new RestRequest($"UpdateEmp/{id}/employee", Method.Put);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("accept", "*/*");
                request.AddJsonBody(hrEmployee);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    Console.WriteLine("Employee updated successfully in Odoo.");
                }
                else
                {
                    Console.WriteLine($"Error updating employee in Odoo: {response.ErrorMessage}");
                }
            }
            else
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var leociaEmployeesContext = scope.ServiceProvider.GetRequiredService<LeociaEmployeesContext>();
                    var existingEmployee = await leociaEmployeesContext.hrEmployees.FindAsync(id);
                    if (existingEmployee != null)
                    {
                        mapper.Map(hrEmployee, existingEmployee);
                        leociaEmployeesContext.hrEmployees.Update(existingEmployee);
                        await leociaEmployeesContext.SaveChangesAsync();
                    }
                }
            }
        }

        public async Task<List<HrEmployee>> GetAllEmployees(string direction)
        {
            if (direction == "Odoo")
            {
                var client = new RestClient("https://localhost:7081/api/HrEmployee");
                var request = new RestRequest("GetEmployees", Method.Get);
                var response = await client.ExecuteAsync<List<Core.Core.Entities.HrEmployee>>(request);
                if (response.IsSuccessful)
                {
                    return mapper.Map<List<HrEmployee>>(response.Data);
                }
                else
                {
                    throw new Exception($"Error retrieving data: {response.ErrorMessage}");
                }
            }
            else
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var leociaEmployeesContext = scope.ServiceProvider.GetRequiredService<LeociaEmployeesContext>();
                    return await leociaEmployeesContext.hrEmployees.ToListAsync();
                }
            }
        }
    }
}
