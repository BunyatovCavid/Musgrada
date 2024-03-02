using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class AboutsConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> b)
        {
            b.HasIndex(a => a.Name).IsUnique();
            b.Property(a => a.Name).IsRequired().HasMaxLength(30);
            b.Property(a => a.Number).IsRequired().HasMaxLength(4);
            b.Property(a => a.TitleId).HasMaxLength(4);
            b.Property(a => a.Image).IsRequired();
        }
    }
}
