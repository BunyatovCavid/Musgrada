using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> b)
        {
            b.HasIndex(t => t.Name).IsUnique();
            b.Property(t => t.Name).IsRequired().HasMaxLength(30);
            b.HasMany(t => t.Abouts)
                .WithOne(a => a.Title)
                .HasForeignKey(a => a.TitleId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
