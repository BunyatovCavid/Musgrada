namespace Musgrada.Domain.Entities
{
    public class Page
    {
       
        public int Id { get; set; }
        public int Number { get; set; }
    
        public List<SpecialOffer>  SpecialOffers { get; set; }

    }
}
