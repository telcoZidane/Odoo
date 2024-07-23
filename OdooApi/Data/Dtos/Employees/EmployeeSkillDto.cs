namespace OdooApi.Data.Dtos.Employees
{
    public class EmployeeSkillDto
    {
        //public int EmployeeId { get; set; }
        public int SkillTypeId { get; set; }
        public int SkillId { get; set; }
        public int SkillLevelId { get; set; }
    }
    public class UpdateEmployeeSkillDto
    {
        public int EmployeeId { get; set; }
        public int SkillTypeId { get; set; }
        public int SkillId { get; set; }
        public int SkillLevelId { get; set; }
    }
}
