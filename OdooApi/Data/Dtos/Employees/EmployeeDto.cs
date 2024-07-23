namespace OdooApi.Data.Dtos.Employees
{
    public class EmployeeDto
    {
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public int JobId { get; set; }
        public string EmployeeType { get; set; }
        public string? WorkEmail { get; set; }
        public int WorkLocationId { get; set; }
        public int AddressId { get; set; }
        public int ParentId { get; set; }
    }
}
