using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> b)
        {
            b.HasIndex(p => p.Name).IsUnique();
            b.Property(p => p.Name).IsRequired().HasMaxLength(30);
            b.HasMany(p => p.CrossDistributorPositions)
                .WithOne(cvp => cvp.Position)
                .HasForeignKey(cvp => cvp.PositionId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
