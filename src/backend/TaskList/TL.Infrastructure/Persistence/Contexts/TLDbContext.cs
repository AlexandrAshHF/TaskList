using Microsoft.EntityFrameworkCore;
using TL.Core.Entities;
using TL.Core.Entities.Application;
using TL.Core.Entities.Empl;

namespace TL.Infrastructure.Persistance.Contexts
{
    public class TLDbContext : BaseDbContext
    {
        public DbSet<TLApplication> Applications => Set<TLApplication>();

        public DbSet<Employee> Employees => Set<Employee>();

        public DbSet<Comment> Comments => Set<Comment>();
        
        public DbSet<Project> Projects => Set<Project>();

        public DbSet<EmployeeInApplication> EmployeesInApplications => Set<EmployeeInApplication>();

        public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();

        public TLDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
