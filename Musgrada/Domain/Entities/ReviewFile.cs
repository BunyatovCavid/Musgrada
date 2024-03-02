namespace Musgrada.Domain.Entities
{
    public class ReviewFile
    {
        public int Id { get; set; }
        public string File { get; set; }
        public int? ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
