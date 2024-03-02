namespace Musgrada.Domain.Entities
{
    public class GoodCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SendCooperative> SendCooperatives { get; set; }
    }
}
