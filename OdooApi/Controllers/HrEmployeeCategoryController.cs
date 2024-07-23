using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrEmployeeCategoryController : ControllerBase
    {
        private readonly ServiceInit _service;

        public HrEmployeeCategoryController(ServiceInit service)
        {
            _service = service;
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

        //Get : Employee categories 
        [HttpGet("GetEmployeeCategories")]
        public async Task<IActionResult> Get()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var employeeCategories = await _service.hrEmployeeCategoryService.GetHrEmpCategories(conn);
                return Ok(employeeCategories);
            }
            catch (Exception ex)
            {
                return BadRequest($"Get employee categories failed {ex.Message}");
            }
        }
    }
}
