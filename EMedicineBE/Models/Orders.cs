namespace EMedicineBE.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string OrderNumber { get; set; }
        public decimal OrderTotal { get; set; }
        public int OrderStatus { get; set; }
    }
}
