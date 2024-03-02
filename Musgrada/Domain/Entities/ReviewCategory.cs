namespace Musgrada.Domain.Entities
{
    public class ReviewCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
