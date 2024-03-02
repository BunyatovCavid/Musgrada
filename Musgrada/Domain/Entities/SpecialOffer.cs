namespace Musgrada.Domain.Entities
{
    public class SpecialOffer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int? PageId { get; set; }
        public Page Page { get; set; }
    }
}
