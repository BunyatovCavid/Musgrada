using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class SpecialOfferConfiguration : IEntityTypeConfiguration<SpecialOffer>
    {
        public void Configure(EntityTypeBuilder<SpecialOffer> b)
        {
            b.HasIndex(so => so.Name).IsUnique();
            b.Property(so => so.Name).IsRequired().HasMaxLength(20);
            b.Property(so => so.Image).IsRequired();
            b.Property(so => so.PageId).HasMaxLength(2);
            b.Property(so => so.Start).IsRequired().HasMaxLength(30);
            b.Property(so => so.End).IsRequired().HasMaxLength(30);
            b.Property(so => so.PageId).HasMaxLength(2);
            
        }
    }
}
