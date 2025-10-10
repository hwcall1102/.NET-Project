namespace TakeawayTitans.Dto
{
    public class OrderItemCreateDto
    {
        public int OrderId { get; set; }     // <-- Add this
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public string? Customization { get; set; }
    }
}

