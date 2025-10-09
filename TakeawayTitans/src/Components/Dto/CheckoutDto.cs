namespace TakeawayTitans.Dto
{
    public class CheckoutDto
    {
        public string CustomerName { get; set; } = default!;
        public string CustomerEmail { get; set; } = default!;
        public string CustomerPhone { get; set; } = default!;
        
        // Optional: status or payment info
        public string Status { get; set; } = "Received";

        // List of items in the cart
        public List<CartItemDto> Items { get; set; } = new();
    }
}
