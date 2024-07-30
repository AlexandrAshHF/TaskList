using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Core.Entities;

namespace TL.Infrastructure.Persistence.Configurations
{
    internal class ApplicationStatusConfiguration : IEntityTypeConfiguration<ApplicationStatus>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatus> builder)
        {
            builder.HasMany(s => s.Applications)
                .WithOne(a => a.Status)
                .HasForeignKey(a => a.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(s => s.Projects)
                .WithMany(p => p.AvailableStatuses)
                .UsingEntity(
                    "ProjectsAppStatuses",
                    l => l.HasOne(typeof(Project)).WithMany().HasForeignKey("ProjectsId"),
                    r => r.HasOne(typeof(ApplicationStatus)).WithMany().HasForeignKey("ApplicationStatusesId"),
                    j => j.HasKey("ProjectsId", "ApplicationStatusesId")
                );

            builder.ComplexProperty(a => a.Color, c =>
            {
                c.IsRequired();
            });
        }
    }
}
