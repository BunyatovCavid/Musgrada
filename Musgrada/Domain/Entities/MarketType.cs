namespace Musgrada.Domain.Entities
{
    public class MarketType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Market> Markets { get; set; }
    }
}
