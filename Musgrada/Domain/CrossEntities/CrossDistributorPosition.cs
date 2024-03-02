using Musgrada.Domain.Entities;

namespace Musgrada.Domain.CrossEntities
{
    public class CrossDistributorPosition
    {
        public int? DistributorId { get; set; }
        public int? PositionId { get; set; }
        public Distributor Distributor { get; set; }
        public Position Position { get; set; }
    }
}
