using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Musgrada.Domain.CrossEntities;

namespace Musgrada.IEntityTypeConfiguration
{
    public class CrossDistributorPositionConfiguration : IEntityTypeConfiguration<CrossDistributorPosition>
    {
        public void Configure(EntityTypeBuilder<CrossDistributorPosition> b)
        {
            b.HasKey(cvp => new { cvp.DistributorId,cvp.PositionId});
            b.Property(cvp => cvp.PositionId).IsRequired().HasMaxLength(2);
            b.Property(cvp => cvp.Distributor).IsRequired().HasMaxLength(4);
        }
    }
}
