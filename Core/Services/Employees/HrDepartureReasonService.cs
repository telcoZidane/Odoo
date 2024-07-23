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
    public class HrDepartureReasonService
    {
        private ServiceMain serviceMain;
        private readonly HrEmployeeService _employeeService;

        public HrDepartureReasonService(ServiceMain serviceMain, HrEmployeeService employeeService)
        {
            this.serviceMain = serviceMain;
            _employeeService = employeeService;
        }
        public async Task<List<HrDepartureReason>> GetHrDepartureReasons(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrDepartureReason.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrDepartureReason>>(jsonResault);
            return listObjects.ToList();
        }

        // Get work location by id
        public async Task<HrDepartureReason> GetById(RpcConnection conn, int id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrDepartureReason.Value());
            requests.RpcFilter.Equal("id", id);
            requests.AddField("id")
                .AddField("name");

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();

            // call get employees method
            var employees = await _employeeService.GetHrEmployees(conn);
            // mapping result with departure reason
            var departureReason = new HrDepartureReason
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
               HrEmployees= employees.Where(e => e.DepartureReasonId == id).ToList(),
            };
            return departureReason;
        }

      // Insert new Departure reason
        public async Task CreateDeparture(RpcConnection conn, HrDepartureReason departureReason, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField> //making a record with fields
            {
                new RpcField{ FieldName = "name", Value = departureReason.Name },
            });
            record.Save(); // save record
        }
        //Update Departure reason
        public async Task UpdateDepartureReason(RpcConnection conn, HrDepartureReason departureReason, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", departureReason.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("name", departureReason.Name);

            result.Save();
        }
        // delete Departure reason
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
