using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class MarketConfiguration : IEntityTypeConfiguration<Market>
    {
        public void Configure(EntityTypeBuilder<Market> b)
        {
            b.HasIndex(m=>m.Name).IsUnique();
            b.Property(m => m.Name).IsRequired().HasMaxLength(30);
            b.Property(m => m.Phone).IsRequired().HasMaxLength(30);
            b.Property(m => m.Adress).IsRequired().HasMaxLength(200);
            b.Property(m => m.Open).IsRequired().HasMaxLength(20);
            b.Property(m => m.Close).IsRequired().HasMaxLength(20);
            b.Property(m => m.MarketTypeId).HasMaxLength(2);
            
        }
    }
}
