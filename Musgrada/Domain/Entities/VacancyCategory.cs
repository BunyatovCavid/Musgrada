namespace Musgrada.Domain.Entities
{
    public class VacancyCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Vacancy> Vacancies { get; set; }
    }
}
