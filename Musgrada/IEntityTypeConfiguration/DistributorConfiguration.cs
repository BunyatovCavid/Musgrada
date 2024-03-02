using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class DistributorConfiguration : IEntityTypeConfiguration<Distributor>
    {
        public void Configure(EntityTypeBuilder<Distributor> b)
        {
            b.HasIndex(d => d.Name).IsUnique();
            b.Property(d => d.Name).IsRequired().HasMaxLength(30);
            b.Property(d => d.Phone).IsRequired().HasMaxLength(30);
            b.Property(d => d.ResidantelAdress).HasMaxLength(200);
            b.Property(d => d.Start).HasMaxLength(30);
            b.Property(d => d.End).HasMaxLength(30);
            b.Property(d => d.ArmyAboutId).HasMaxLength(2);
            b.Property(d => d.EducationId).HasMaxLength(2);
            b.Property(d => d.Age).IsRequired().HasMaxLength(2);
            b.Property(d => d.Fin).IsRequired().HasMaxLength(10);
            b.Property(d => d.Description).IsRequired();
            b.Property(d => d.Experience).HasMaxLength(30);
            b.HasMany(d => d.CrossDistributorPositions)
                .WithOne(cdp => cdp.Distributor)
                .HasForeignKey(cdp => cdp.DistributorId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
