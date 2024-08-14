using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Core.Entities;

namespace TL.Infrastructure.Persistence.Configurations
{
    internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasOne(p => p.ParrentProject)
                .WithMany(ip => ip.InternalProjects)
                .HasForeignKey(p => p.ParrentProjectId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
