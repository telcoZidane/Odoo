using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Services.Employees
{
    public class HrDepartmentService
    {
        private readonly ServiceMain serviceMain;
        private readonly HrEmployeeService _employeeService;
        public HrDepartmentService(ServiceMain serviceMain, HrEmployeeService employeeService)
        {
            this.serviceMain = serviceMain;
            _employeeService = employeeService;
        }
        public async Task GetHrDepartments(RpcConnection conn)
        {
            var companyId1 = 1;
            var requests = new RpcContext(conn, EnumsOdoo.HrDepartment.Value());
            requests
                .RpcFilter.Equal("id", companyId1).And().Equal("company_id", companyId1);
            var data = requests.Execute(true);

        }

        // get departments
        public async Task<List<HrDepartment>> GetAllHrDepartments(RpcConnection conn)
        {
            var employees = await _employeeService.GetHrEmployees(conn);

            var requests = new RpcContext(conn, EnumsOdoo.HrDepartment.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrDepartment>>(jsonResault);

            var dpts = (from dpt in listObjects
                        select new HrDepartment()
                        {
                            Id = dpt.Id,
                            MessageMainAttachmentId = dpt.MessageMainAttachmentId,
                            CompanyId = dpt.CompanyId,
                            ParentId = dpt.ParentId,
                            ManagerId = dpt.ManagerId,
                            Color = dpt.Color,
                            MasterDepartmentId = dpt.MasterDepartmentId,
                            CreateUid = dpt.CreateUid,
                            WriteUid = dpt.WriteUid,
                            Name = dpt.Name,
                            CompleteName = dpt.CompleteName,
                            ParentPath = dpt.ParentPath,
                            Note = dpt.Note,
                            Active = dpt.Active,
                            CreateDate = dpt.CreateDate,
                            WriteDate = dpt.WriteDate,
                            Company = dpt.Company,
                            CreateU = dpt.CreateU,
                            HrApplicants = dpt.HrApplicants,
                            HrContracts = dpt.HrContracts,
                            HrEmployeeSkillLogs = dpt.HrEmployeeSkillLogs,
                            HrEmployees = employees.Where(e => e.DepartmentId == dpt.Id).ToList(),
                            HrExpenseSheets = dpt.HrExpenseSheets,
                            HrJobs = dpt.HrJobs,
                            HrLeaveAllocations = dpt.HrLeaveAllocations,
                            HrLeaves = dpt.HrLeaves,
                            HrPlans = dpt.HrPlans,
                            InverseMasterDepartment = dpt.InverseMasterDepartment,
                            InverseParent = dpt.InverseParent,
                            MaintenanceEquipments = dpt.MaintenanceEquipments,
                            Manager = dpt.Manager,
                            MasterDepartment = dpt.MasterDepartment,
                            MessageMainAttachment = dpt.MessageMainAttachment,
                            Parent = dpt.Parent,
                            WriteU = dpt.WriteU,
                            HrLeaveStressDays = dpt.HrLeaveStressDays,
                            MailChannels = dpt.MailChannels,
                        }).ToList();
            return dpts;
        }
        // get department by id
        public async Task<HrDepartment> GetById(RpcConnection conn, int Id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrDepartment.Value());
            requests.RpcFilter.Equal("id", Id);

            requests.AddField("id")
                .AddField("name")
                .AddField("manager_id")
                .AddField("parent_id");

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();
            // mapping result with employee
            var hrDepartment = new HrDepartment
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                ManagerId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "manager_id")),
                ParentId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "parent_id")),
            };
            return hrDepartment;
        }

        public async Task Create(RpcConnection conn,HrDepartment hrDepartment, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField>//making a record with fields
            {
                new RpcField{FieldName = "name", Value = hrDepartment.Name},
                new RpcField{FieldName = "manager_id", Value = hrDepartment.ManagerId},
                new RpcField{FieldName = "parent_id", Value = hrDepartment.ParentId},
                //the others fields is going to be "null" or filled by the system it self for example CreateDate 
            });
            record.Save();//saving the record
        }
        public async Task Update(RpcConnection conn, HrDepartment hrDepartment, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", hrDepartment.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("name", hrDepartment.Name);
            result.SetFieldValue("manager_id", hrDepartment.ManagerId);
            result.SetFieldValue("parent_id", hrDepartment.ParentId);
            //fill these fields with new value but the rest stay as they was

            result.Save();// saving the record
        }
        public async Task DeleteModel(RpcConnection conn,EnumsOdoo model,int Id)
        {
            var request = new RpcContext(conn, model.Value());//making request with "EnumsOdoo" that contains all tables
            request.RpcFilter.Equal("id", Id);//filter by Id to get one object to be deleted
            var result = request.Execute(true).FirstOrDefault();//executing the request
            var rcpModel = new RpcModel(model.Value(), conn);//making Rpcmodel here as same as request object type
            rcpModel.Remove(result);//executing the deleted operation
        }
        public async Task DeleteModel(RpcConnection conn, EnumsOdoo model, int[] Ids)
        {
            var request = new RpcContext(conn, model.Value());//making request with "EnumsOdoo" that contains all tables
            request.RpcFilter.In("id", Ids);//filter by Id to get list object to be deleted
            var result = request.Execute(true).ToList();//executing the request
            var rcpModel = new RpcModel(EnumsOdoo.HrDepartment.Value(), conn);//making Rpcmodel here as same as request object type
            rcpModel.Remove(result);//executing the deleted operation
        }
    }
}
