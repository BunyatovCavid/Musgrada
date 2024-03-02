using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> b)
        {
            b.Property(p => p.Number).IsRequired().HasMaxLength(2);
            b.HasMany(p => p.SpecialOffers)
                .WithOne(so => so.Page)
                .HasForeignKey(p => p.PageId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
