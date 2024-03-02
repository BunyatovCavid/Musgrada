namespace Musgrada.Domain.Entities
{
    public class Cooperative
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public List<SendCooperative> SendCooperatives { get; set; }
    }
}
