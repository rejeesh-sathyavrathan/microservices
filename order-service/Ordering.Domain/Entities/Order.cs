namespace Ordering.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsCancelled { get; set; }
        // Add domain logic and validation as needed
    }

    public class OrderItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        // Add domain logic and validation as needed
    }
}
