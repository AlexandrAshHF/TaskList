using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Core.Entities.Application;

namespace TL.Infrastructure.Persistence.Configurations
{
    internal class EpmlInAppConfiguration : IEntityTypeConfiguration<EmployeeInApplication>
    {
        public void Configure(EntityTypeBuilder<EmployeeInApplication> builder)
        {
            builder.HasOne(ea => ea.Employee)
                .WithMany(e => e.EmployeeInApplications)
                .HasForeignKey(ea => ea.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ea => ea.Application)
                .WithMany(a => a.Employees)
                .HasForeignKey(ea => ea.ApplicationId);
        }
    }
}
