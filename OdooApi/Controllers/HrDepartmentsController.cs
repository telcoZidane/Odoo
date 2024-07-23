using Core.Core.Context;
using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.Departments;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrDepartmentsController : ControllerBase
    {
        //private DbOdooContext dbodooContext;
        public ServiceInit serviceInit;
        public HrDepartmentsController(/*DbOdooContext dbodooContext ,*/ ServiceInit serviceInit)
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
        // get department (.. problem)  Solved 12-4-2023
        [HttpGet("GetDepartments")]
        public async Task<IActionResult> GetDepartments()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var depts = await serviceInit.hrDepartmentService.GetAllHrDepartments(conn);
                return Ok(depts);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        // post : create department
        [HttpPost("CreateDepartment")]
        public async Task<ActionResult> CreateDepartment(DepartmentDto departmentDto)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrDepartment;
                HrDepartment hrDepartment = new HrDepartment
                {
                    Name = departmentDto.Name,
                    ManagerId = departmentDto.ManagerId,
                    ParentId = departmentDto.ParentId,
                };
                await serviceInit.hrDepartmentService.Create(conn, hrDepartment, model);
                return Ok(hrDepartment);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //12-4-2023
        // put : Update department
        [HttpPut("UpdateDepartment/{id}/employee")]
        public async Task<ActionResult> UpdateDepartment(int id, DepartmentDto departmentdto)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrDepartment;
                var existingDept = await serviceInit.hrDepartmentService.GetById(conn, id);
                if (existingDept == null)
                {
                    return NotFound();
                }
                else
                {
                    existingDept.Name = departmentdto.Name;
                    existingDept.ManagerId = departmentdto.ManagerId;
                    existingDept.ParentId = departmentdto.ParentId;
                }
                await serviceInit.hrDepartmentService.Update(conn, existingDept, model);
                return Ok(existingDept);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        // delete : delete employee
        [HttpDelete("DeleteDepartment")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrDepartment;// get enums

                // call service delete method
                await serviceInit.hrDepartmentService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting employee: {ex.Message}");
            }
        }
        // delete : delete employee
        [HttpDelete("DeleteDepartments")]
        public async Task<IActionResult> Delete(int[] ids)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrDepartment;// get enums

                // call service delete method
                await serviceInit.hrDepartmentService.DeleteModel(conn, eModel, ids);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting employee: {ex.Message}");
            }
        }
    }
}
