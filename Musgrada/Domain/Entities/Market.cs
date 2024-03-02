namespace Musgrada.Domain.Entities
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public int? MarketTypeId { get; set; }
        public MarketType MarketType { get; set; }
    }
}
