using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class CooperativeConfiguration : IEntityTypeConfiguration<Cooperative>
    {
        public void Configure(EntityTypeBuilder<Cooperative> b)
        {
             b.HasIndex(c => c.Name).IsUnique();
            b.Property(c => c.Name).IsRequired().HasMaxLength(30);
            b.Property(c => c.Image).IsRequired();
            b.Property(c => c.Description).IsRequired();
            b.HasMany(c => c.SendCooperatives)
                .WithOne(sc => sc.Cooperative)
                .HasForeignKey(sc => sc.CooperativeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
