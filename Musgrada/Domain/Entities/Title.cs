namespace Musgrada.Domain.Entities
{
    public class Title
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<About> Abouts { get; set; }
    }
}
