using Azure.Core;
using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services.Employees
{
    public class HrSkillService
    {
        private ServiceMain serviceMain;
        public HrSkillService(ServiceMain serviceMain)
        {

            this.serviceMain = serviceMain;

        }
        public async Task<List<HrSkillType>> GetHrSkills(RpcConnection conn)
        {
            var listObjectsSkillType = new List<HrSkillType>();
            var listObjectsSkill = new List<HrSkill>();
            var listObjectsSkillLevel = new List<HrSkillLevel>();

            var requestSkillType = new RpcContext(conn, EnumsOdoo.HrSkillType.Value()).Execute(true);
            var requestSkill = new RpcContext(conn, EnumsOdoo.HrSkill.Value()).Execute(true);
            var requestSkillLevel = new RpcContext(conn, EnumsOdoo.HrSkillLevel.Value()).Execute(true);

            var jsonResaultSkillType = serviceMain.RpcContextToJson(requestSkillType);
            var jsonResaultSkill = serviceMain.RpcContextToJson(requestSkill);
            var jsonResaultSkillLevel = serviceMain.RpcContextToJson(requestSkillLevel);

            listObjectsSkillType = JsonConvert.DeserializeObject<List<HrSkillType>>(jsonResaultSkillType);
            listObjectsSkill = JsonConvert.DeserializeObject<List<HrSkill>>(jsonResaultSkill);
            listObjectsSkillLevel = JsonConvert.DeserializeObject<List<HrSkillLevel>>(jsonResaultSkillLevel);

            var listSkillType = (from ST in listObjectsSkillType
                                   select new HrSkillType()
                                   {
                                       Id = ST.Id,
                                       CreateDate = ST.CreateDate,
                                       CreateU = ST.CreateU,
                                       CreateUid = ST.CreateUid,
                                       WriteDate = ST.WriteDate,
                                       WriteU = ST.WriteU,
                                       WriteUid = ST.WriteUid,
                                       Name = ST.Name,
                                       HrSkills = listObjectsSkill.Where(w=>w.SkillTypeId == ST.Id).ToList(),
                                       HrSkillLevels = listObjectsSkillLevel.Where(w => w.SkillTypeId == ST.Id).ToList()
                                   }).ToList();

            return listSkillType;
        }

        // get skillType by id  12-5-2023
        public async Task<HrSkillType> GetById(RpcConnection conn, int Id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrSkillType.Value());
            requests.RpcFilter.Equal("id", Id);

            requests.AddField("id")
                .AddField("name")
                ;

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();
            var skills = await GetSkillsBySkillTypeId(conn, Id);
            var skillLevels = await GetSkillLevelsBySkillTypeId(conn, Id);
            // mapping result with skillType
            var hrskillType = new HrSkillType
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                HrSkills=skills,
                HrSkillLevels=skillLevels,
            };
            return hrskillType;
        }

        // get Skills by SkillType Id
        public async Task<List<HrSkill>> GetSkillsBySkillTypeId(RpcConnection conn, int SkillTypeId)
        {
            var listObjectsSkill = new List<HrSkill>();
            var requestSkill = new RpcContext(conn, EnumsOdoo.HrSkill.Value()).Execute(true);
            var jsonResaultSkill = serviceMain.RpcContextToJson(requestSkill);
            listObjectsSkill = JsonConvert.DeserializeObject<List<HrSkill>>(jsonResaultSkill);
            
            var SkillsWithSkillTypeId = listObjectsSkill.Where(st=> st.SkillTypeId == SkillTypeId).ToList();
            return SkillsWithSkillTypeId;

        }
        // get SkillLevels by SkillType Id
        public async Task<List<HrSkillLevel>> GetSkillLevelsBySkillTypeId(RpcConnection conn, int SkillTypeId)
        {
            var listSkillLevel = new List<HrSkillLevel>();
            var requestSkillLevel = new RpcContext(conn, EnumsOdoo.HrSkillLevel.Value()).Execute(true);
            var jsonResaultSkillLevel = serviceMain.RpcContextToJson(requestSkillLevel);
            listSkillLevel = JsonConvert.DeserializeObject<List<HrSkillLevel>>(jsonResaultSkillLevel);

            var SkillLevelWithSkillTypeId = listSkillLevel.Where(st => st.SkillTypeId == SkillTypeId).ToList();
            return SkillLevelWithSkillTypeId;

        }

        // create new skills
        public async Task CreateSkill(RpcConnection conn, HrSkillType skillType, EnumsOdoo model)
        {
            RpcRecord skillTypeRecord = new RpcRecord(conn, model.Value(), -1, new List<RpcField>
            {
                new RpcField{FieldName="name" , Value=skillType.Name}
            });
            skillTypeRecord.Save();
            
        }
        
        // Create skills
        public async Task CreateSkills(RpcConnection conn, List<HrSkill> hrSkills, int SkillTypeId, EnumsOdoo model)
        {
            var skillType = await GetById(conn, SkillTypeId);
            foreach (var skill in hrSkills)
            {
                RpcRecord skillRecord = new RpcRecord(conn, model.Value(), -1, new List<RpcField>
                    {
                        new RpcField{FieldName="name" , Value=skill.Name},
                        new RpcField{FieldName="skill_type_id" , Value=skillType.Id},
                    });
                skillRecord.Save();
            }
        }
        // Create skill levels
        public async Task CreateSkillLevels(RpcConnection conn, List<HrSkillLevel> skillLevels, int SkillTypeId, EnumsOdoo model)
        {
            var skillType = await GetById(conn, SkillTypeId);
            foreach (var skillLevel in skillLevels)
            {
                RpcRecord skillLevelRecord = new RpcRecord(conn, model.Value(), -1, new List<RpcField>
                {
                        new RpcField{FieldName="skill_type_id" , Value=skillType.Id},
                        new RpcField{FieldName="name" , Value=skillLevel.Name},
                        new RpcField{FieldName="level_progress" , Value=skillLevel.LevelProgress},
                        //new RpcField{FieldName="default_level" , Value=skillLevel.DefaultLevel},
                    });
                skillLevelRecord.Save();
            }
        }


      // Update
        //Update skill type
        public async Task UpdateSkillType(RpcConnection conn, HrSkillType skillType, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            request.RpcFilter.Equal("id", skillType.Id);//filter by Id to get that one object we want
            var result = request.Execute(true).FirstOrDefault();//executing the request

            result.SetFieldValue("name", skillType.Name);
            //result.SetFieldValue("HrSkills", skillType.HrSkills); 
            //result.SetFieldValue("HrSkillLevels", skillType.HrSkillLevels);
            result.Save();
        }

        //Update skill type
        public async Task UpdateSkills(RpcConnection conn, List<HrSkill> skills, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            foreach (var skill in skills)
            {
                request.RpcFilter.Equal("id", skill.Id);//filter by Id to get that one object we want
                var result = request.Execute(true).FirstOrDefault();//executing the request

                result.SetFieldValue("name", skill.Name);
                result.Save();
            }   
        }

        //Update skill type
        public async Task UpdateSkillLevels(RpcConnection conn, List<HrSkillLevel> skillLevels, EnumsOdoo model)
        {
            var request = new RpcContext(conn, model.Value());//making a record with fields
            foreach (var skillLevel in skillLevels)
            {
                request.RpcFilter.Equal("id", skillLevel.Id);//filter by Id to get that one object we want
                var result = request.Execute(true).FirstOrDefault();//executing the request

                result.SetFieldValue("name", skillLevel.Name);
                result.SetFieldValue("level_progress", skillLevel.LevelProgress);
                result.Save();
            }
        }


        // delete skill
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
