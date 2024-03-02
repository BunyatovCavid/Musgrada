using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> b)
        {
            b.HasIndex(e => e.Name).IsUnique();
            b.Property(e => e.Name).IsRequired().HasMaxLength(60);
            b.HasMany(e => e.Distributors)
                .WithOne(d => d.Education)
                .HasForeignKey(d => d.EducationId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
