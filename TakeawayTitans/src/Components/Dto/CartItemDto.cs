namespace TakeawayTitans.Dto
{
    public class CartItemDto
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
        public string? Customization { get; set; }

        // Optional: Image for display
        public string? ImageUrl { get; set; }
    }
}
