using Musgrada.Domain.CrossEntities;

namespace Musgrada.Domain.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CrossDistributorPosition> CrossDistributorPositions { get; set; }
    }
}
