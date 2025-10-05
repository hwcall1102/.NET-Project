namespace TakeawayTitans.Dto
{
    public class OrderItemCreateDto
    {
        public int MenuItemId { get; set; }     // Which menu item
        public int Quantity { get; set; }       // How many
        public string? Customization { get; set; } // Notes (special instructions)
    }
}
