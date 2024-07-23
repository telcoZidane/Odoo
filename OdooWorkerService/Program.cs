using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OdooWorkerService;
using OdooWorkerService.DataAccess;
using System.Reflection;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<LeociaEmployeesContext>(op=> 
        op.UseSqlServer(context.Configuration.GetConnectionString("LeociaConnection")));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
