using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services.Employees
{
    public class HrJobService
    {
        private ServiceMain serviceMain;
        private readonly HrEmployeeService _employeeService;

        public HrJobService(ServiceMain serviceMain, HrEmployeeService employeeService)
        {

            this.serviceMain = serviceMain;
            _employeeService = employeeService;
        }
        public async Task<List<HrJob>> GetHrJobs(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrJob.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrJob>>(jsonResault);
            return listObjects.ToList();
        }

        public async Task<List<HrContractType>> GetHrContractType(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrContractType.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrContractType>>(jsonResault);
            return listObjects.ToList();
        }

        // Get job by id
        public async Task<HrJob> GetById(RpcConnection conn, int id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrJob.Value());
            requests.RpcFilter.Equal("id", id);
            requests.AddField("id")
                .AddField("name")
                .AddField("company_id")
                .AddField("department_id")
                .AddField("manager_id")
                .AddField("address_id")
                .AddField("contract_type_id")
                .AddField("no_of_recruitment")
                .AddField("is_published")
                .AddField("description")
                ;

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();

            // mapping result with departure reason
            var departureReason = new HrJob
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                CompanyId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "company_id")),
                DepartmentId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "department_id")),
                ManagerId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "manager_id")),
                AddressId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "address_id")),
                ContractTypeId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "contract_type_id")),
                NoOfRecruitment = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "no_of_recruitment")),
                IsPublished = Convert.ToBoolean(serviceMain.GetFieldArrayValue(result, "is_published")),
                Description = serviceMain.GetFieldArrayValue(result, "description").ToString(),
            };
            return departureReason;
        }
        
        // post new job
        public async Task CreateNewJob(RpcConnection conn, HrJob job, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField> //making a record with fields
            {
                new RpcField{ FieldName = "name", Value = job.Name },
                new RpcField{ FieldName = "company_id", Value = job.CompanyId },
                new RpcField{ FieldName = "department_id", Value = job.DepartmentId },
                new RpcField{ FieldName = "manager_id", Value = job.ManagerId },
                new RpcField{ FieldName = "address_id", Value = job.AddressId },              
                new RpcField{ FieldName = "contract_type_id", Value = job.ContractTypeId },    
                new RpcField{ FieldName = "no_of_recruitment", Value = job.NoOfRecruitment },
                new RpcField{ FieldName = "is_published", Value = job.IsPublished },
                //new RpcField{ FieldName = "job_details", Value = job.JobDetails },
                new RpcField{ FieldName = "description", Value = job.Description },
                
                //new RpcField{ FieldName = "active", Value = job.Active },
                
            });
            record.Save(); // save record
        }

        //Update job
        public async Task UpdateJob(RpcConnection conn, HrJob newJob, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", newJob.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request
           
            result.SetFieldValue("name", newJob.Name);
            result.SetFieldValue("company_id", newJob.CompanyId);
            result.SetFieldValue("department_id", newJob.DepartmentId);
            result.SetFieldValue("manager_id", newJob.ManagerId);
            result.SetFieldValue("address_id", newJob.AddressId);
            result.SetFieldValue("contract_type_id", newJob.ContractTypeId);
            result.SetFieldValue("no_of_recruitment", newJob.NoOfRecruitment);
            result.SetFieldValue("is_published", newJob.IsPublished);
            result.SetFieldValue("description", newJob.Description);

            result.Save();
        }
        // delete job
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
