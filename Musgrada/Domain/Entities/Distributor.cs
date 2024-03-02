using Musgrada.Domain.CrossEntities;

namespace Musgrada.Domain.Entities
{
    public class Distributor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public int Fin { get; set; }
        public string Phone { get; set; }
        public string? ResidantelAdress { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string? Experience { get; set; }
        public string? ExperinceCompanydescription { get; set; }
        public string Description { get; set; }

        public int? ArmyAboutId { get; set; }
        public int? EducationId { get; set; }
        public ArmyAbout ArmyAbout { get; set; }
        public Education Education { get; set; }
        public List<CrossDistributorPosition>  CrossDistributorPositions { get; set; }
    }
}
