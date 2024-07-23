using Microsoft.EntityFrameworkCore;
using OdooWorkerService.Entities;

namespace OdooWorkerService.DataAccess;

public partial class LeociaEmployeesContext : DbContext
{
    
    public LeociaEmployeesContext(DbContextOptions<LeociaEmployeesContext> dbContextOptions):base(dbContextOptions)
    {
        
    }
    public DbSet<HrEmployee> hrEmployees { get; set; }
}
