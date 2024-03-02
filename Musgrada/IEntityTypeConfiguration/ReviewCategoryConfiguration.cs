using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class ReviewCategoryConfiguration : IEntityTypeConfiguration<ReviewCategory>
    {
        public void Configure(EntityTypeBuilder<ReviewCategory> b)
        {
            b.HasIndex(rc=>rc.Name).IsUnique();
            b.Property(rc => rc.Name).IsRequired().HasMaxLength(20);
            b.HasMany(rc => rc.Reviews)
                .WithOne(r => r.ReviewCategory)
                .HasForeignKey(r => r.ReviewCategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
