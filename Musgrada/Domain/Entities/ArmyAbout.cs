namespace Musgrada.Domain.Entities
{
    public class ArmyAbout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Distributor> Distributors { get; set; }
    }
}
