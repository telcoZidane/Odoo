using Core.Core.Context;
using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.Employees;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrEmployeeController : ControllerBase
    {
        //private DbOdooContext dbodooContext;
        public ServiceInit serviceInit;

        public HrEmployeeController(/*DbOdooContext dbodooContext,*/ ServiceInit serviceInit)
        {
            //this.dbodooContext = dbodooContext;
            this.serviceInit = serviceInit;
           
        }

        //Get connection
        [HttpGet("connection")]
        public RpcConnection GetConnection()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var rpcConnnectionSettings = new RpcConnectionSetting();

            config.GetSection("OdooConnection").Bind(rpcConnnectionSettings);

            //Connection
            var conn = new RpcConnection(rpcConnnectionSettings);
            return conn;
        }

        //Get employee
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployee()
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrEmployee;

                var employee = await serviceInit.hrEmployeeService.GetHrEmployees(conn);
                return Ok(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //Post create action
        [HttpPost("CreateEmp")]
        public async Task<IActionResult> Create(EmployeeDto hrEmployeeDto)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployee;// get enums

                HrEmployee hrEmployee = new HrEmployee// instanciate new hremployee
                {
                    Name = hrEmployeeDto.Name,
                    DepartmentId = hrEmployeeDto.DepartmentId,
                    JobId = hrEmployeeDto.JobId,
                    EmployeeType = hrEmployeeDto.EmployeeType,
                    WorkEmail = hrEmployeeDto.WorkEmail,
                    WorkLocationId = hrEmployeeDto.WorkLocationId,
                    AddressId = hrEmployeeDto.AddressId,
                    ParentId = hrEmployeeDto.ParentId,

                };
                // call service create method
                await serviceInit.hrEmployeeService.CreateEmployee(conn, hrEmployee, eModel);
                return Ok(hrEmployee);

            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating employee: {ex.Message}");
            }

        }


        // put :modify Employee  29-11-23
        [HttpPut("UpdateEmp/{id}/employee")]
        public async Task<IActionResult> Update(int id, EmployeeDto hrEmployeeDto)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployee;// get enums
                //get existing employee by Id
                var ExistHrEmployee = await serviceInit.hrEmployeeService.GetById(conn, id);
                if (ExistHrEmployee == null)
                {
                    return NotFound();
                }
                else
                {
                    // modify the employee fields
                    ExistHrEmployee.Name = hrEmployeeDto.Name;
                    ExistHrEmployee.DepartmentId = hrEmployeeDto.DepartmentId;
                    ExistHrEmployee.JobId = hrEmployeeDto.JobId;
                    ExistHrEmployee.EmployeeType = hrEmployeeDto.EmployeeType;
                    ExistHrEmployee.WorkEmail = hrEmployeeDto.WorkEmail;
                    ExistHrEmployee.WorkLocationId = hrEmployeeDto.WorkLocationId;
                    ExistHrEmployee.AddressId = hrEmployeeDto.AddressId;
                    ExistHrEmployee.ParentId = hrEmployeeDto.ParentId;
                }

                // effectue the update
                await serviceInit.hrEmployeeService.UpdateEmployee(conn, ExistHrEmployee, eModel);
                return Ok(ExistHrEmployee);

            }
            catch (Exception ex)
            {
                return BadRequest($"Update employee failed: {ex.Message}");
            }

        }

        // delete : delete employee
        [HttpDelete("DeleteEmployee")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployee;// get enums

                // call service delete method
                await serviceInit.hrEmployeeService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting employee: {ex.Message}");
            }
        }

      // employees skills
        //Post create action
        [HttpPost("CreateEmpSkill")]
        public async Task<IActionResult> CreateEmployeeSkill(EmployeeSkillDto employeeSkill,int EmployeeId)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployeeSkill;// get enums
                var employee= await serviceInit.hrEmployeeService.GetById(conn, EmployeeId);
                var skillType = await serviceInit.hrSkillService.GetById(conn, employeeSkill.SkillTypeId);
                if(employee!=null && skillType!=null)
                {
                    HrEmployeeSkill _employeeSkill = new HrEmployeeSkill
                    {
                        EmployeeId = EmployeeId,
                        SkillTypeId = employeeSkill.SkillTypeId,
                        SkillId = employeeSkill.SkillId,
                        SkillLevelId = employeeSkill.SkillLevelId,
                    };
                   // call service create method
                    await serviceInit.hrEmployeeService.CreateEmployeeSkills(conn, _employeeSkill, eModel);
                    return Ok(_employeeSkill);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating employee: {ex.Message}");
            }

        }

        //Get employees skills
        [HttpGet("GetEmployeesSkills")]
        public async Task<IActionResult> GetEmployeeSSkills()
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrEmployee;

                var employeesSkills = await serviceInit.hrEmployeeService.GetEmployeeSkills(conn);
                return Ok(employeesSkills);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        // put :modify Employee skill  
        [HttpPut("UpdateEmpSkill/{id}/employee")]
        public async Task<IActionResult> UpdateEmpSkill(int id, UpdateEmployeeSkillDto employeeSkillDto)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployeeSkill;// get enums
                //get existing employee by Id
                var ExistHrEmpSkill = await serviceInit.hrEmployeeService.GetEmployeSkillById(conn, id);
                if (ExistHrEmpSkill == null)
                {
                    return NotFound();
                }
                else
                {
                    // modify the employee fields
                    ExistHrEmpSkill.EmployeeId = employeeSkillDto.EmployeeId;
                    ExistHrEmpSkill.SkillTypeId = employeeSkillDto.SkillTypeId;
                    ExistHrEmpSkill.SkillId = employeeSkillDto.SkillId;
                    ExistHrEmpSkill.SkillLevelId = employeeSkillDto.SkillLevelId;
                  
                }

                // effectue the update
                await serviceInit.hrEmployeeService.UpdateEmployeeSkill(conn, ExistHrEmpSkill, eModel);
                return Ok(ExistHrEmpSkill);

            }
            catch (Exception ex)
            {
                return BadRequest($"Error Update employee skills: {ex.Message}");
            }

        }
        // delete : delete employee skill
        [HttpDelete("DeleteEmployeeSkill")]
        public async Task<IActionResult> DeleteEmployeeSkill(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrEmployeeSkill;// get enums

                // call service delete method
                await serviceInit.hrEmployeeService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting employee skill: {ex.Message}");
            }
        }
    }
}
