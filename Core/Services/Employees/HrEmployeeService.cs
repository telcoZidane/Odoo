using Azure.Core;
using Core.Core.Context;
using Core.Core.Entities;
using Core.Core.Utility;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services.Employees
{
    public class HrEmployeeService
    {
       private readonly ServiceMain serviceMain;
        public HrEmployeeService(ServiceMain serviceMain)
        {
            this.serviceMain = serviceMain;
        }

        public async Task<List<HrEmployee>> GetHrEmployees(RpcConnection conn)
        {
            //await serviceMain.GetList<HrEmployee>(conn); 
            await serviceMain.GetAllWithRelated<HrSkillType>(conn); 
            var EmployeeSkills=await GetEmployeeSkills(conn);

            //var employee = new HrEmployee()
            //{
            //    HrResumeLines=null,
            //    HrSkills=null,
            //    ResourceCalendar,
            //};

            var listHrResumeLines = await GetHrResumes(conn);
            //var listHrSkills = await serviceInit.hrSkillService.GetHrSkills(conn);

            var requests = new RpcContext(conn, EnumsOdoo.HrEmployee.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrEmployee>>(jsonResault);

            var obj = (from HE in listObjects
                       select new HrEmployee()
                       {
                           Id = HE.Id,
                           ResourceId = HE.ResourceId,
                           CompanyId = HE.CompanyId,
                           ResourceCalendarId = HE.ResourceCalendarId,
                           MessageMainAttachmentId = HE.MessageMainAttachmentId,
                           Color = HE.Color,
                           DepartmentId = HE.DepartmentId,
                           JobId = HE.JobId,
                           AddressId = HE.AddressId,
                           WorkContactId = HE.WorkContactId,
                           WorkLocationId = HE.WorkLocationId,
                           UserId = HE.UserId,
                           ParentId = HE.ParentId,
                           CoachId = HE.CoachId,
                           AddressHomeId = HE.AddressHomeId,
                           CountryId = HE.CountryId,
                           Children = HE.Children,
                           CountryOfBirth = HE.CountryOfBirth,
                           BankAccountId = HE.BankAccountId,
                           KmHomeWork = HE.KmHomeWork,
                           DepartureReasonId = HE.DepartureReasonId,
                           CreateUid = HE.CreateUid,
                           WriteUid = HE.WriteUid,
                           Name = HE.Name,
                           JobTitle = HE.JobTitle,
                           WorkPhone = HE.WorkPhone,
                           MobilePhone = HE.MobilePhone,
                           WorkEmail = HE.WorkEmail,
                           EmployeeType = HE.EmployeeType,
                           Gender = HE.Gender,
                           Marital = HE.Marital,
                           SpouseCompleteName = HE.SpouseCompleteName,
                           PlaceOfBirth = HE.PlaceOfBirth,
                           Ssnid = HE.Ssnid,
                           Sinid = HE.Sinid,
                           IdentificationId = HE.IdentificationId,
                           PassportId = HE.PassportId,
                           PermitNo = HE.PermitNo,
                           VisaNo = HE.VisaNo,
                           Certificate = HE.Certificate,
                           StudyField = HE.StudyField,
                           StudySchool = HE.StudySchool,
                           EmergencyContact = HE.EmergencyContact,
                           EmergencyPhone = HE.EmergencyPhone,
                           Barcode = HE.Barcode,
                           Pin = HE.Pin,
                           SpouseBirthdate = HE.SpouseBirthdate,
                           Birthday = HE.Birthday,
                           VisaExpire = HE.VisaExpire,
                           WorkPermitExpirationDate = HE.WorkPermitExpirationDate,
                           DepartureDate = HE.DepartureDate,
                           AdditionalNote = HE.AdditionalNote,
                           Notes = HE.Notes,
                           DepartureDescription = HE.DepartureDescription,
                           Active = HE.Active,
                           WorkPermitScheduledActivity = HE.WorkPermitScheduledActivity,
                           CreateDate = HE.CreateDate,
                           WriteDate = HE.WriteDate,
                           ContractId = HE.ContractId,
                           Vehicle = HE.Vehicle,
                           FirstContractDate = HE.FirstContractDate,
                           ContractWarning = HE.ContractWarning,
                           ExpenseManagerId = HE.ExpenseManagerId,
                           LeaveManagerId = HE.LeaveManagerId,
                           MobilityCard = HE.MobilityCard,
                           LastAttendanceId = HE.LastAttendanceId,
                           LastCheckIn = HE.LastCheckIn,
                           LastCheckOut = HE.LastCheckOut,
                           Address = HE.Address,
                           AddressHome = HE.AddressHome,
                           BankAccount = HE.BankAccount,
                           Coach = HE.Coach,
                           Company = HE.Company,
                           Contract = HE.Contract,
                           Country = HE.Country,
                           CountryOfBirthNavigation = HE.CountryOfBirthNavigation,
                           CreateU = HE.CreateU,
                           Department = HE.Department,
                           DepartureReason = HE.DepartureReason,
                           ExpenseManager = HE.ExpenseManager,
                           FleetVehicleAssignationLogs = HE.FleetVehicleAssignationLogs,
                           FleetVehicleDriverEmployees = HE.FleetVehicleDriverEmployees,
                           FleetVehicleFutureDriverEmployees = HE.FleetVehicleFutureDriverEmployees,
                           FleetVehicleLogServices = HE.FleetVehicleLogServices,
                           GamificationBadgeUserWizards = HE.GamificationBadgeUserWizards,
                           GamificationBadgeUsers = HE.GamificationBadgeUsers,
                           HrApplicants = HE.HrApplicants,
                           HrAttendanceOvertimes = HE.HrAttendanceOvertimes,
                           HrAttendances = HE.HrAttendances,
                           HrContracts = HE.HrContracts,
                           HrDepartments = HE.HrDepartments,
                           HrDepartureWizards = HE.HrDepartureWizards,
                           HrEmployeeSkillLogs = HE.HrEmployeeSkillLogs,
                           HrEmployeeSkills =EmployeeSkills.Where(es=> es.EmployeeId == HE.Id).ToList(),
                           HrExpenseSheets = HE.HrExpenseSheets,
                           HrExpenseSplits = HE.HrExpenseSplits,
                           HrExpenses = HE.HrExpenses,
                           HrJobs = HE.HrJobs,
                           HrLeaveAllocationApprovers = HE.HrLeaveAllocationApprovers,
                           HrLeaveAllocationEmployees = HE.HrLeaveAllocationEmployees,
                           HrLeaveAllocationManagers = HE.HrLeaveAllocationManagers,
                           HrLeaveEmployees = HE.HrLeaveEmployees,
                           HrLeaveFirstApprovers = HE.HrLeaveFirstApprovers,
                           HrLeaveManagers = HE.HrLeaveManagers,
                           HrLeaveSecondApprovers = HE.HrLeaveSecondApprovers,
                           HrResumeLines = listHrResumeLines.Where(w=>w.EmployeeId == HE.Id).ToList(),
                           InverseCoach = HE.InverseCoach,
                           InverseParent = HE.InverseParent,
                           Job = HE.Job,
                           LastAttendance = HE.LastAttendance,
                           LeaveManager = HE.LeaveManager,
                           MaintenanceEquipments = HE.MaintenanceEquipments,
                           MaintenanceRequests = HE.MaintenanceRequests,
                           MessageMainAttachment = HE.MessageMainAttachment,
                           Parent = HE.Parent,
                           PosOrders = HE.PosOrders,
                           Resource = HE.Resource,
                           ResourceCalendar = HE.ResourceCalendar,
                           User = HE.User,
                           WorkContact = HE.WorkContact,
                           WorkLocation = HE.WorkLocation,
                           WriteU = HE.WriteU,
                           Categories = HE.Categories,
                           Employees = HE.Employees,
                           HrLeaveAllocations = HE.HrLeaveAllocations,
                           HrLeaves = HE.HrLeaves,
                           HrSkills = HE.HrSkills,
                           PosConfigs = HE.PosConfigs,
                           Sums = HE.Sums
                       }).ToList();

            return listObjects.ToList();
        }
        public async Task<List<HrResumeLine>> GetHrResumes(RpcConnection conn)
        {
            var requestHrResumeLineType = new RpcContext(conn, EnumsOdoo.HrResumeLineType.Value()).Execute(true);
            var jsonResaultHrResumeLineType = serviceMain.RpcContextToJson(requestHrResumeLineType);
            var listObjectsHrResumeLineType = JsonConvert.DeserializeObject<List<HrResumeLineType>>(jsonResaultHrResumeLineType);


            var requestHrResumeLine = new RpcContext(conn, EnumsOdoo.HrResumeLine.Value()).Execute(true);
            var jsonResaultHrResumeLine = serviceMain.RpcContextToJson(requestHrResumeLine);
            var listObjectsHrResumeLine = JsonConvert.DeserializeObject<List<HrResumeLine>>(jsonResaultHrResumeLine);

            var listResume = (from RL in  listObjectsHrResumeLine
                              select new HrResumeLine()
                              {
                                  Id = RL.Id,
                                  ChannelId = RL.ChannelId,
                                  Channel = RL.Channel,
                                  CreateDate = RL.CreateDate,
                                  CreateU = RL.CreateU,
                                  CreateUid = RL.CreateUid,
                                  DateEnd = RL.DateEnd,
                                  DateStart = RL.DateStart,
                                  Description = RL.Description,
                                  DisplayType = RL.DisplayType,
                                  Employee = RL.Employee,
                                  EmployeeId = RL.EmployeeId,
                                  LineType = listObjectsHrResumeLineType.Where(w=>w.Id == RL.LineTypeId).FirstOrDefault(),
                                  LineTypeId = RL.LineTypeId,
                                  Name = RL.Name,
                                  SurveyId = RL.SurveyId,
                                  Survey = RL.Survey,
                                  WriteDate = RL.WriteDate,
                                  WriteU = RL.WriteU,
                                  WriteUid = RL.WriteUid,
                              }).ToList();
            return listResume;
        }

        // (11-28-2023)

        // get hrEmpolyee
        public async Task<HrEmployee> GetById(RpcConnection conn, int Id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrEmployee.Value());
            requests.RpcFilter.Equal("id", Id);
            requests.AddField("id")
                .AddField("name")
                .AddField("job_id")
                .AddField("department_id")
                .AddField("work_email")
                .AddField("work_location_id")
                .AddField("address_id")
                .AddField("parent_id");
            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();
            // mapping result with employee
            var hremployee = new HrEmployee
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                JobId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "job_id")),
                DepartmentId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "department_id")),
                WorkEmail =serviceMain.GetFieldArrayValue(result, "work_email").ToString(),
                WorkLocationId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "work_location_id")),
                AddressId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "address_id")),
                ParentId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "parent_id")),
            };
            return hremployee;
        }
       


        // Insert new employee (11-28-2023)
        public async Task CreateEmployee(RpcConnection conn, HrEmployee hrEmployee, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField> //making a record with fields
            {
                new RpcField{ FieldName = "name", Value = hrEmployee.Name },
                new RpcField{ FieldName = "department_id", Value = hrEmployee.DepartmentId},
                new RpcField{ FieldName = "job_id", Value = hrEmployee.JobId },
                //new RpcField{ FieldName = "company_id", Value = hrEmployee.CompanyId },
                //new RpcField{ FieldName = "work_email", Value = hrEmployee.WorkEmail },
                new RpcField{ FieldName = "work_email", Value = hrEmployee.WorkEmail },
                new RpcField{ FieldName = "work_location_id", Value = hrEmployee.WorkLocationId },
                new RpcField{ FieldName = "address_id", Value = hrEmployee.AddressId },
                new RpcField{ FieldName = "parent_id", Value = hrEmployee.ParentId },

            });
            record.Save(); // save record
        }

        // update employee (11-28-2023)
        public async Task UpdateEmployee(RpcConnection conn, HrEmployee hrEmployee, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", hrEmployee.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("name", hrEmployee.Name);
            result.SetFieldValue("depatment_id", hrEmployee.DepartmentId);
            result.SetFieldValue("job_title", hrEmployee.JobId);
            //result.SetFieldValue("company_id", hrEmployee.CompanyId);
            result.SetFieldValue("work_email", hrEmployee.WorkEmail);
            result.SetFieldValue("work_location_id", hrEmployee.WorkLocationId);
            result.SetFieldValue("address_id", hrEmployee.AddressId);
            result.SetFieldValue("parent_id", hrEmployee.ParentId);

            result.Save(); // save updated fields
        }


        // delete 29-11-23
        public async Task DeleteModel(RpcConnection conn, EnumsOdoo model, int Id)
        {
            var request = new RpcContext(conn, model.Value());//making request with "EnumsOdoo" that contains all tables
            request.RpcFilter.Equal("id", Id);//filter by Id to get one object to be deleted
            var result = request.Execute(true).FirstOrDefault();//executing the request
            var rcpModel = new RpcModel(model.Value(), conn);//making Rpcmodel here as same as request object type
            rcpModel.Remove(result);//executing the deleted operation
        }
     //Employee skills 
        //get employee skill
        public async Task<List<HrEmployeeSkill>> GetEmployeeSkills(RpcConnection conn)
        {
            //var employees=await GetHrEmployees(conn);

            var requests = new RpcContext(conn, EnumsOdoo.HrEmployeeSkill.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrEmployeeSkill>>(jsonResault);

            var employeesSkills=(from ES in listObjects
                                 select new HrEmployeeSkill()
                                 {
                                     Id= ES.Id,
                                     EmployeeId=ES.EmployeeId,
                                     SkillId=ES.SkillId,
                                     SkillTypeId=ES.SkillTypeId,
                                     SkillLevelId=ES.SkillLevelId,
                                     CreateUid=ES.CreateUid,
                                     WriteUid=ES.WriteUid,
                                     CreateDate=ES.CreateDate,
                                     WriteDate=ES.WriteDate,
                                     CreateU=ES.CreateU,  
                                 }).ToList();
            return employeesSkills;
        }

        // get hrEmpolyee
        public async Task<HrEmployeeSkill> GetEmployeSkillById(RpcConnection conn, int Id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrEmployeeSkill.Value());
            requests.RpcFilter.Equal("id", Id);
            requests.AddField("id")
                .AddField("employee_id")
                .AddField("skill_type_id")
                .AddField("skill_id")
                .AddField("skill_level_id");
            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();
            // mapping result with employee
            var hremployeeSkill = new HrEmployeeSkill
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                EmployeeId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "employee_id")),
                SkillTypeId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "skill_type_id")),
                SkillId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "skill_id")),
                SkillLevelId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "skill_level_id")),
               
            };
            return hremployeeSkill;
        }

        // Create skills Employee
        public async Task CreateEmployeeSkills(RpcConnection conn, HrEmployeeSkill employeeSkill, EnumsOdoo model)
        {
            RpcRecord record = new RpcRecord(conn, model.Value(), -1, new List<RpcField> //making a record with fields
            {
                new RpcField{ FieldName = "employee_id", Value = employeeSkill.EmployeeId },
                new RpcField{ FieldName = "skill_type_id", Value = employeeSkill.SkillTypeId },                
                new RpcField{ FieldName = "skill_id", Value = employeeSkill.SkillId },
                new RpcField{ FieldName = "skill_level_id", Value = employeeSkill.SkillLevelId },
            });
            record.Save(); // save record
        }

        // update employee skills
        public async Task UpdateEmployeeSkill(RpcConnection conn, HrEmployeeSkill hrEmployeeSkill, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", hrEmployeeSkill.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("employee_id", hrEmployeeSkill.EmployeeId);
            result.SetFieldValue("skill_type_id", hrEmployeeSkill.SkillTypeId);
            result.SetFieldValue("skill_id", hrEmployeeSkill.SkillId);
            result.SetFieldValue("skill_level_id", hrEmployeeSkill.SkillLevelId);

            result.Save(); // save updated fields
        }
        
    }
}
