namespace ECommerce.Search.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
