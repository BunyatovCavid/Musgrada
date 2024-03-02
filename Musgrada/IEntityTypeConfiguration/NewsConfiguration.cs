using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> b)
        {
            b.HasIndex(n => n.Name).IsUnique();
            b.Property(n => n.Name).IsRequired().HasMaxLength(50);
            b.Property(n => n.Image).IsRequired();
            b.Property(n => n.Description).IsRequired();
        }
    }
}
