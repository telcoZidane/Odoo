using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.Jobs;
using OdooApi.Data.Dtos.WorkLocation;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrJobController : ControllerBase
    {
        private readonly ServiceInit _service;

        public HrJobController(ServiceInit service)
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

        //Get : Job (success)
        [HttpGet("GetJobs")]
        public async Task<IActionResult> Get()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var jobs = await _service.hrJobService.GetHrJobs(conn);
                return Ok(jobs);
            }
            catch (Exception ex)
            {
                return BadRequest($"Get jobs failed {ex.Message}");
            }
        }
        //Post new job
        [HttpPost("CreateJob")]
        public async Task<IActionResult> Create(JobDto job)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrJob;// get enums

                HrJob newJob = new HrJob// instanciate new hremployee
                {
                    Name = job.Name,
                    CompanyId = job.CompanyId,
                    DepartmentId = job.DepartmentId,
                    AddressId = job.AddressId,
                    ContractTypeId = job.ContractTypeId,
                    NoOfRecruitment=job.NoOfRecruitment,
                    IsPublished=job.IsPublished,
                    ManagerId=job.ManagerId,
                    Description=job.Description,
                    
                    

                };
                // call service create method
                await _service.hrJobService.CreateNewJob(conn, newJob, eModel);
                return Ok(newJob);

            }
            catch (Exception ex)
            {
                return BadRequest($"Create work job failed: {ex.Message}");
            }

        }
        //put : create hr skill levels of a skilType
        [HttpPut("UpdateJob")]
        public async Task<ActionResult> Update(int id, JobDto updatedJob)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrJob;

                var ExistingJob = await _service.hrJobService.GetById(conn, id);
                if (ExistingJob == null)
                {
                    return NotFound();
                }
                else
                {
                    ExistingJob.Name = updatedJob.Name;
                    ExistingJob.CompanyId = updatedJob.CompanyId;
                    ExistingJob.DepartmentId = updatedJob.DepartmentId;
                    ExistingJob.AddressId = updatedJob.AddressId;
                    ExistingJob.ContractTypeId = updatedJob.ContractTypeId;
                    ExistingJob.NoOfRecruitment= updatedJob.NoOfRecruitment;
                    ExistingJob.IsPublished= updatedJob.IsPublished;
                    ExistingJob.ManagerId= updatedJob.ManagerId;
                    ExistingJob.Description= updatedJob.Description;
                    
                    await _service.hrJobService.UpdateJob(conn, ExistingJob, model);
                    return Ok(ExistingJob);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Update job failed: {ex.Message}");
            }
        }
        // delete : delete job
        [HttpDelete("DeleteJob")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrJob;// get enums

                // call service delete method
                await _service.hrJobService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"deleting job failed: {ex.Message}");
            }
        }
    }
}
