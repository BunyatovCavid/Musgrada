namespace Musgrada.Domain.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SendVacancyCV> SendVacancyCVs { get; set; }
    }
}
