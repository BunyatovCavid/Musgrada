using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class SendCooperativeConfiguration : IEntityTypeConfiguration<SendCooperative>
    {
        public void Configure(EntityTypeBuilder<SendCooperative> b)
        {
            b.Property(sc => sc.Name).IsRequired().HasMaxLength(30);
            b.Property(sc => sc.Email).IsRequired().HasMaxLength(30);
            b.Property(sc => sc.Phone).IsRequired().HasMaxLength(30);
            b.Property(sc => sc.Description).IsRequired().HasMaxLength(30);
            b.Property(sc => sc.CompanyName).HasMaxLength(50);
            b.Property(sc => sc.MinArea).HasMaxLength(10);
            b.Property(sc => sc.MaxArea).HasMaxLength(10);
            b.Property(sc => sc.CooperativeId).HasMaxLength(4);
            b.Property(sc => sc.GoodCategoryId).HasMaxLength(4);
            b.Property(sc => sc.WholeSaleTypeId).HasMaxLength(4);
        }
    }
}
