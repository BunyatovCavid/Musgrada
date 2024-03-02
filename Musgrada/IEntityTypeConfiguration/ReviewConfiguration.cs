using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> b)
        {
            b.HasIndex(r => r.Name).IsUnique();
            b.Property(r => r.Name).IsRequired().HasMaxLength(20);
            b.Property(r => r.Phone).IsRequired().HasMaxLength(20);
            b.Property(r => r.Email).IsRequired().HasMaxLength(20);
            b.Property(r => r.Description).IsRequired();
            b.Property(r => r.ReviewCategoryId).HasMaxLength(2);
            b.HasMany(r => r.ReviewFiles)
                .WithOne(rf => rf.Review)
                .HasForeignKey(rf=>rf.ReviewId)
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
