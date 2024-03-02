using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> b)
        {
            b.HasIndex(c => c.Name).IsUnique();
            b.Property(c => c.Name).IsRequired().HasMaxLength(20);
            b.Property(c => c.Image).IsRequired();
            b.Property(c => c.Description).IsRequired();
            b.Property(c => c.Title).IsRequired().HasMaxLength(20);
        }
    }
}
