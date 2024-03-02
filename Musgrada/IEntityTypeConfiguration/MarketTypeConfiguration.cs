using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class MarketTypeConfiguration : IEntityTypeConfiguration<MarketType>
    {
        public void Configure(EntityTypeBuilder<MarketType> b)
        {
            b.HasIndex(mt => mt.Name).IsUnique();
            b.Property(mt => mt.Name).IsRequired().HasMaxLength(20);
            b.HasMany(mt => mt.Markets)
                .WithOne(m => m.MarketType)
                .HasForeignKey(m => m.MarketTypeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
