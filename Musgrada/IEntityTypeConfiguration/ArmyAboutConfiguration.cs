using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class ArmyAboutConfiguration : IEntityTypeConfiguration<ArmyAbout>
    {
        public void Configure(EntityTypeBuilder<ArmyAbout> b)
        {
            b.HasIndex(aa => aa.Name).IsUnique();
            b.Property(aa => aa.Name).IsRequired().HasMaxLength(60);
            b.HasMany(aa => aa.Distributors)
                .WithOne(d => d.ArmyAbout)
                .HasForeignKey(d => d.ArmyAboutId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
