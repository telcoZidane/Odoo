using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services.Employees
{
    public class HrWorkLocationService
    {
        private ServiceMain serviceMain;
        private readonly HrEmployeeService _employeeService;
        public HrWorkLocationService(ServiceMain serviceMain, HrEmployeeService employeeService)
        {
            this.serviceMain = serviceMain;
            _employeeService = employeeService;
        }

        public async Task<List<HrWorkLocation>> GetHrWorkLocations(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrWorkLocation.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrWorkLocation>>(jsonResault);

            var employees = await _employeeService.GetHrEmployees(conn);

            var result = (from WL in listObjects
                          select new HrWorkLocation()
                          {
                              Id = WL.Id,
                              Name = WL.Name,
                              CompanyId = WL.CompanyId,
                              AddressId = WL.AddressId,
                              CreateUid = WL.CreateUid,
                              WriteUid = WL.WriteUid,
                              LocationNumber = WL.LocationNumber,
                              Active = WL.Active,
                              CreateDate = WL.CreateDate,
                              WriteDate = WL.WriteDate,
                              HrEmployees = employees.Where(e => e.WorkLocationId == WL.Id).ToList(),

                          }).ToList();
            return result;
        }

        // Get work location by id
        public async Task<HrWorkLocation> GetById(RpcConnection conn, int id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrWorkLocation.Value());
            requests.RpcFilter.Equal("id", id);
            requests.AddField("id")
                .AddField("company_id")
                .AddField("address_id")
                .AddField("name")
                .AddField("active");

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();

            // call get employees method
            var employees = await _employeeService.GetHrEmployees(conn);
            // mapping result with workLocation
            var workLocation = new HrWorkLocation
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                CompanyId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "company_id")),
                AddressId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "address_id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                Active = Convert.ToBoolean(serviceMain.GetFieldArrayValue(result, "active")),
                HrEmployees = employees.Where(e=>e.WorkLocationId == id).ToList(),
            };
            return workLocation;
        }

        // Insert new work location
        public async Task CreateWorkLocation(RpcConnection conn, HrWorkLocation workLocation, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField> //making a record with fields
            {
                new RpcField{ FieldName = "company_id", Value = workLocation.CompanyId },
                new RpcField{ FieldName = "address_id", Value = workLocation.AddressId },
                new RpcField{ FieldName = "name", Value = workLocation.Name },
                new RpcField{ FieldName = "active", Value = workLocation.Active! },
            });
            record.Save(); // save record
        }

        // Update
        //Update Work location
        public async Task UpdateWorkLocation(RpcConnection conn, HrWorkLocation workLocation, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", workLocation.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("company_id", workLocation.CompanyId);
            result.SetFieldValue("address_id", workLocation.AddressId);
            result.SetFieldValue("name", workLocation.Name);
            result.SetFieldValue("active", workLocation.Active!);
            
            result.Save();
        }
        // delete work location
        public async Task DeleteModel(RpcConnection conn, EnumsOdoo model, int Id)
        {
            var request = new RpcContext(conn, model.Value());//making request with "EnumsOdoo" that contains all tables
            request.RpcFilter.Equal("id", Id);//filter by Id to get one object to be deleted
            var result = request.Execute(true).FirstOrDefault();//executing the request
            var rcpModel = new RpcModel(model.Value(), conn);//making Rpcmodel here as same as request object type
            rcpModel.Remove(result);//executing the deleted operation
        }
    }
}
