namespace Musgrada.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public int? ReviewCategoryId { get; set; }
        public ReviewCategory ReviewCategory { get; set; }
        public List<ReviewFile> ReviewFiles { get; set; }
    }
}
