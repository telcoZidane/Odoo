using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.DepartureReason;
using OdooApi.Data.Dtos.WorkLocation;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrDepartureReasonController : ControllerBase
    {

        private readonly ServiceInit _service;

        public HrDepartureReasonController(ServiceInit service)
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

        //Get : Departure Reasons
        [HttpGet("GetDepartureReason")]
        public async Task<IActionResult> Get()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var departureReasons = await _service.hrDepartureReasonService.GetHrDepartureReasons(conn);
                return Ok(departureReasons);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        //Get Work departure reason by id
        [HttpGet("GetDepartureReasonById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();

                var departureReason = await _service.hrDepartureReasonService.GetById(conn, id);
                if (departureReason is not null)
                {
                    return Ok(departureReason);
                }
                return NotFound("Departure reason not found");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        //Post: Create new Departure Reason 
        [HttpPost("CreateDepartureReason")]
        public async Task<IActionResult> Create(DepartureReasonDto departureReasonDto)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrDepartureReason;// get enums

                HrDepartureReason departureReason = new HrDepartureReason// instanciate new hremployee
                {
                    Name=departureReasonDto.Name!
                };
                // call service create method
                await _service.hrDepartureReasonService.CreateDeparture(conn, departureReason, eModel);
                return Ok(departureReason);

            }
            catch (Exception ex)
            {
                return BadRequest($"Create Departure Reason failed: {ex.Message}");
            }

        }
        //put : Update Departure Reason
        [HttpPut("UpdateDepartureReason")]
        public async Task<ActionResult> Update(int id, DepartureReasonDto newDepartureReason)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrDepartureReason;

                var ExistingDepartureReason = await _service.hrDepartureReasonService.GetById(conn, id);
                if (ExistingDepartureReason == null)
                {
                    return NotFound();
                }
                else
                {
                    
                    ExistingDepartureReason.Name = newDepartureReason.Name;
                   
                    await _service.hrDepartureReasonService.UpdateDepartureReason(conn, ExistingDepartureReason, model);
                    return Ok(ExistingDepartureReason);

                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Update Departure Reason failed: {ex.Message}");
            }
        }


        // delete : delete Departure Reason
        [HttpDelete("DeleteDepartureReason")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrDepartureReason;// get enums

                // call service delete method
                await _service.hrDepartureReasonService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Delete departure Reason failed: {ex.Message}");
            }
        }
    }
}
