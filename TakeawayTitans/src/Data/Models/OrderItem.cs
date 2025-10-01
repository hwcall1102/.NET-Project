namespace TakeawayTitans.Data.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        // Foreign keys
        public int OrderId { get; set; }
        public Order Order { get; set; } = default!;

        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; } = default!;

        public int Quantity { get; set; } = 1;

        // New customization field
        public string? Customization { get; set; }
    }
}
