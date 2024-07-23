using Core.Core.Context;
using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Odoo.Concrete;
using OdooApi.Data.Dtos.Skills;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HrSkillsController : ControllerBase
    {
        //private DbOdooContext dbodooContext;
        public ServiceInit serviceInit;
        public HrSkillsController(/*DbOdooContext dbodooContext,*/ ServiceInit serviceInit)
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

        // get HrSkillType
        [HttpGet("GetSkills")]
        public async Task<IActionResult> GetSkills()
        {
            try
            {
                RpcConnection conn = GetConnection();

                var skills = await serviceInit.hrSkillService.GetHrSkills(conn);
                return Ok(skills);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        // Post: Create skill type
        [HttpPost("CreateSkillType")]
        public async Task<ActionResult> CreateSkillType(CreateSkillTypeDto skillTypeDto)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrSkillType;

                HrSkillType skillType = new HrSkillType
                {
                    Name = skillTypeDto.Name,
                };
                // call create method
                await serviceInit.hrSkillService.CreateSkill(conn, skillType, model);
                return Ok("Skill Creation successful");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        //post : create hr skills of a skilType
        [HttpPost("CreateSkills")]
        public async Task<ActionResult> CreateSkills(List<SkillDto> skills,int skillTypeId)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrSkill;

                // find skill type by id
                var skillType=await serviceInit.hrSkillService.GetById(conn, skillTypeId);
                if(skillType == null)
                {
                    return NotFound();
                }
                else
                {
                    List<HrSkill> hrSkills = new List<HrSkill>();
                    foreach(var skill in skills)
                    {
                        HrSkill hrSkill = new HrSkill
                        {
                            SkillTypeId = skillType.Id,
                            Name = skill.Name
                        };
                        hrSkills.Add(hrSkill);
                    }
                // call create method
                await serviceInit.hrSkillService.CreateSkills(conn, hrSkills,skillTypeId, model);
                return Ok("Skills Creation successful");
                }  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        //post : create hr skill levels of a skilType
        [HttpPost("CreateSkillLevels")]
        public async Task<ActionResult> CreateSkillLevel(List<SkillLevelDto> skillLevels, int skillTypeId)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrSkillLevel;

                // find skill type by id
                var skillType = await serviceInit.hrSkillService.GetById(conn, skillTypeId);
                if (skillType == null)
                {
                    return NotFound();
                }
                else
                {
                    // List that store skillLevels
                    List<HrSkillLevel> hrSkillLevels = new List<HrSkillLevel>();
                    foreach (var skillLevel in skillLevels)
                    {
                        HrSkillLevel hrSkillLevel = new HrSkillLevel
                        {
                            SkillTypeId = skillType.Id,
                            Name = skillLevel.Name,
                            LevelProgress=skillLevel.Progress_level,
                            //DefaultLevel=skillLevel.Default_level
                        };
                        hrSkillLevels.Add(hrSkillLevel);
                    }
                    // call create method
                    await serviceInit.hrSkillService.CreateSkillLevels(conn, hrSkillLevels, skillTypeId, model);
                    return Ok("Skill levels Creation successful");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        // Put: update 
        //put : create hr skill levels of a skilType
        [HttpPut("Update")]
        public async Task<ActionResult> UpdateSkill(UpdateHrSkillTypeDto NewhrSkill, int skillTypeId)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.HrSkillType;
                EnumsOdoo Skillsmodel = EnumsOdoo.HrSkill;
                EnumsOdoo SkillLevelsmodel = EnumsOdoo.HrSkillLevel;
                var ExistingSkillType = await serviceInit.hrSkillService.GetById(conn, skillTypeId);
                if (ExistingSkillType == null)
                {
                    return NotFound();
                }
                else
                {
                   if (skillTypeId != 0) { 
                        ExistingSkillType.Name = NewhrSkill.Name;

                        //var hrSkills = ExistingSkillType.HrSkills;

                        foreach (var newHrskill in NewhrSkill.skillDtos)
                        {
                            var existSkill = ExistingSkillType.HrSkills.SingleOrDefault(sk => sk.Id == newHrskill.Id);
                            if (existSkill == null)
                            {
                                var _hrskills=new HrSkill
                                {
                                    SkillTypeId=ExistingSkillType.Id,
                                    Name=newHrskill.Name
                                };
                                ExistingSkillType.HrSkills.Add(_hrskills);                           
                                await serviceInit.hrSkillService.CreateSkills(conn, ExistingSkillType.HrSkills.ToList(), ExistingSkillType.Id, Skillsmodel);

                            }else if(existSkill != null)
                            {
                                existSkill.SkillTypeId = ExistingSkillType.Id;
                                existSkill.Name = newHrskill.Name;                        
                                await serviceInit.hrSkillService.UpdateSkills(conn, ExistingSkillType.HrSkills.ToList(), Skillsmodel);

                            }

                        
                        }

                        foreach (var newHrSkilllevel in NewhrSkill.skillLevelDtos)
                        {
                            var existSkillLevel = ExistingSkillType.HrSkillLevels.SingleOrDefault(sk => sk.Id == newHrSkilllevel.Id);
                            if(existSkillLevel == null)
                            {
                                var _hrskillLevel = new HrSkillLevel
                                {
                                    //SkillTypeId = ExistingSkillType.Id,
                                    Name = newHrSkilllevel.Name,
                                    LevelProgress = newHrSkilllevel.Progress_level
                                };
                                ExistingSkillType.HrSkillLevels.Add(_hrskillLevel);                            
                                await serviceInit.hrSkillService.CreateSkillLevels(conn, ExistingSkillType.HrSkillLevels.ToList(), ExistingSkillType.Id, SkillLevelsmodel);

                            }else if (existSkillLevel != null)
                            {
                                //existSkillLevel.SkillTypeId = ExistingSkillType.Id;
                                existSkillLevel.Name = newHrSkilllevel.Name;
                                existSkillLevel.LevelProgress = newHrSkilllevel.Progress_level;
                                await serviceInit.hrSkillService.UpdateSkillLevels(conn, ExistingSkillType.HrSkillLevels.ToList(), SkillLevelsmodel);

                            }

                        }
                        
                        await serviceInit.hrSkillService.UpdateSkillType(conn, ExistingSkillType, model);
                        return Ok("Skill type update successful!");
                   }
                    return BadRequest("Skill type update faile!");

                }
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }  
        }

        // delete : delete employee
        [HttpDelete("DeleteSkillType")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();// get connection
                EnumsOdoo eModel = EnumsOdoo.HrSkillType;// get enums

                // call service delete method
                await serviceInit.hrSkillService.DeleteModel(conn, eModel, id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest($"Error deleting Skill: {ex.Message}");
            }
        }
    }
}
