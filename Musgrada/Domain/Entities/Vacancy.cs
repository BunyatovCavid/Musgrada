using System.ComponentModel;

namespace Musgrada.Domain.Entities
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CityId { get; set; }
        public int? VacancyCategoryId { get; set; }
        public City City { get; set; }
        public VacancyCategory VacancyCategory { get; set; }
        public List<SendVacancyCV>  SendVacancyCVs { get; set; }
    }
}
