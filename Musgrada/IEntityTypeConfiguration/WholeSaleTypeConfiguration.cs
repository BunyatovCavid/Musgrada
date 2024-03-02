using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class WholeSaleTypeConfiguration : IEntityTypeConfiguration<WholeSaleType>
    {
        public void Configure(EntityTypeBuilder<WholeSaleType> b)
        {
            b.HasIndex(wst => wst.Name).IsUnique();
            b.Property(wst => wst.Name).IsRequired().HasMaxLength(30);
            b.HasMany(wst => wst.SendCooperatives)
                .WithOne(sc => sc.WholeSaleType)
                .HasForeignKey(sc => sc.WholeSaleTypeId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
