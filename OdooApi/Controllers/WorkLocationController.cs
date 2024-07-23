using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.Employees;
using OdooApi.Data.Dtos.Skills;
using OdooApi.Data.Dtos.WorkLocation;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkLocationController : ControllerBase
    {
        private readonly ServiceInit _service;

        public WorkLocationController(ServiceInit service)
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

        //Get Work locations
        [HttpGet("GetWorkLocations")]
        public async Task<IActionResult> Get()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var workLocations = await _service.hrWorkLocationService.GetHrWorkLocations(conn);
                return Ok(workLocations);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        //Get Work locations
        [HttpGet("GetWorkLocationsbyId/{id}")]
        public async Task<IActionResult> GetWorkLocById(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();

                var workLocation = await _service.hrWorkLocationService.GetById(conn,id);
                if(workLocation is not null)
                {
                    return Ok(workLocation);
                }
                return BadRequest("Work location not found");
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //Post create action
        [HttpPost("CreateWorkLocation")]
        public async Task<IActionResult> Create(WorkLocationDto locationDto)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrWorkLocation;// get enums

                HrWorkLocation workLocation = new HrWorkLocation// instanciate new hremployee
                {
                   CompanyId = locationDto.CompanyId,
                   AddressId= locationDto.AddressId,
                   Name= locationDto.Name,
                   Active= locationDto.Active,

                };
                // call service create method
                await _service.hrWorkLocationService.CreateWorkLocation(conn, workLocation, eModel);
                return Ok(workLocation);

            }
            catch (Exception ex)
            {
                return BadRequest($"Error creating work location: {ex.Message}");
            }

        }
        //put : create hr skill levels of a skilType
        [HttpPut("Update")]
        public async Task<ActionResult> UpdateWorkLocation(int id, WorkLocationDto newWorkLocation)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrWorkLocation;
                
                var ExistingWorkLocation = await _service.hrWorkLocationService.GetById(conn, id);
                if (ExistingWorkLocation == null)
                {
                    return NotFound();
                }
                else
                {
                    ExistingWorkLocation.CompanyId= newWorkLocation.CompanyId;
                    ExistingWorkLocation.AddressId= newWorkLocation.AddressId;
                    ExistingWorkLocation.Name= newWorkLocation.Name;
                    ExistingWorkLocation.Active= newWorkLocation.Active;

                    await _service.hrWorkLocationService.UpdateWorkLocation(conn, ExistingWorkLocation, model);
                    return Ok(ExistingWorkLocation);

                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Update work location failed: {ex.Message}");
            }
        }


      // delete : delete Work location
        [HttpDelete("DeleteWorkLocation")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrWorkLocation;// get enums

                // call service delete method
                await _service.hrWorkLocationService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"deleting work location failed: {ex.Message}");
            }
        }
    }
}
