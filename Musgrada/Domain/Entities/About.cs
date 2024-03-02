namespace Musgrada.Domain.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int? TitleId { get; set; }
        public Title Title { get; set; }
    }
}
