namespace Musgrada.Domain.Entities
{
    public class SendCooperative
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string? CompanyName { get; set; }
        public string? Position { get; set; }
        public string? Adress { get; set; }
        public string Description { get; set; }
        public float? MinArea { get; set; }
        public float? MaxArea { get; set; }
        

        public int? CooperativeId { get; set; }
        public int? GoodCategoryId { get; set; }
        public int? WholeSaleTypeId { get; set; }
        public WholeSaleType WholeSaleType { get; set; }
        public GoodCategory  GoodCategory { get; set; }
        public Cooperative Cooperative { get; set; }

    }
}
