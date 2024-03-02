namespace Musgrada.Domain.Entities
{
    public class SendVacancyCV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? SubName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Cv { get; set; }
        public string? ResidentalAdress  { get; set; }
        public DateTime? Birthday { get; set; }


        public int? VacancyId { get; set; }
        public int? GenderId { get; set; }
        public Vacancy Vacancy { get; set; }
        public Gender Gender { get; set; }
    }
}
