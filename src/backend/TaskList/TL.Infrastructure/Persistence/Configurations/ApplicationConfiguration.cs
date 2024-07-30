using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TL.Core.Entities.Application;

namespace TL.Infrastructure.Persistence.Configurations
{
    internal class ApplicationConfiguration : IEntityTypeConfiguration<TLApplication>
    {
        public void Configure(EntityTypeBuilder<TLApplication> builder)
        {
            builder.HasOne(a => a.Status)
                .WithMany(s => s.Applications)
                .HasForeignKey(a => a.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Project)
                .WithMany(p => p.Applications)
                .HasForeignKey(a => a.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(a => a.Employees)
                .WithOne(ea => ea.Application)
                .HasForeignKey(ea => ea.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ComplexProperty(a => a.Description, d =>
            {
                d.IsRequired();
                d.Property(v => v.Marking).HasColumnName("Marking");
                d.Property(v => v.Images).HasColumnName("ImageLinks");
            });
        }
    }
}
