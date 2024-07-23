namespace OdooApi.Data.Dtos.Departments
{
    public class DepartmentDto
    {
        public string? Name { get; set; }
        public int ManagerId { get; set; }
        public int ParentId { get; set; }
    }
}
