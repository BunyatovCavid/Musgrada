using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class GoodCategoryConfiguration : IEntityTypeConfiguration<GoodCategory>
    {
        public void Configure(EntityTypeBuilder<GoodCategory> b)
        {
            b.HasIndex(gc => gc.Name).IsUnique();
            b.Property(gc => gc.Name).IsRequired().HasMaxLength(30);
            b.HasMany(gc => gc.SendCooperatives)
                .WithOne(sc => sc.GoodCategory)
                .HasForeignKey(sc => sc.GoodCategoryId)
                .OnDelete(DeleteBehavior.SetNull);
           
        }
    }
}
