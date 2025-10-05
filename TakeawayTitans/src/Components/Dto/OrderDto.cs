namespace TakeawayTitans.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; } = "Pending";   // Pending, Preparing, Completed, etc.
        public DateTime CreatedAt { get; set; }

        public List<OrderItemDto> Items { get; set; } = new();
        public decimal TotalPrice { get; set; }
    }
}
