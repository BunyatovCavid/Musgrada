using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.Entities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class ReviewFileConfiuration : IEntityTypeConfiguration<ReviewFile>
    {
        public void Configure(EntityTypeBuilder<ReviewFile> b)
        {
            b.Property(rf => rf.File).IsRequired();
            b.Property(rf => rf.ReviewId).HasMaxLength(5);
        }
    }
}
