namespace OdooApi.Data.Dtos.Skills
{
    public class UpdateHrSkillTypeDto
    {
        public string Name { get; set; }
        public List<UpdateHrSkillsDto>? skillDtos { get; set; }
        public List<UpdateHrSkillLevelsDto>? skillLevelDtos { get; set; }
    }

    // HrSkills Dto for update
    public class UpdateHrSkillsDto
    {
        public int Id { get; set; }
        //public int SkillTypeId { get; set; }
        public string Name { get; set; }
    }

    // HrSkillLevel dto for update
    public class UpdateHrSkillLevelsDto
    {
        public int Id { get; set; }
        //public int SkillTypeId { get; set; }
        public string Name { get; set; }
        public int Progress_level { get; set; }
    }
}
