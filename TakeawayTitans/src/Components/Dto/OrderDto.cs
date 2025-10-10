namespace TakeawayTitans.Dto
{
    using TakeawayTitans.Data.Models;

    public class OrderDto
{
    public int Id { get; set; }
    public int UserId { get; set; }

    public string? CustomerName { get; set; }
    public string? CustomerPhone { get; set; }
    public string? CustomerEmail { get; set; }

    public string? OrderCode { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Received;
    public DateTime CreatedAt { get; set; }

    public List<OrderItemDto> Items { get; set; } = new();
    public decimal TotalPrice { get; set; }
}

}
