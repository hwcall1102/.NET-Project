using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Data.Models
{
    public enum OrderStatus
    {
        Received,
        Preparing,
        Ready,
        Completed,
        Canceled
    }

    public class Order
    {
        public int OrderId { get; set; }

        [MaxLength(100)]
        public string? CustomerName { get; set; }

        [MaxLength(20), Phone]
        public string? CustomerPhone { get; set; }

        [MaxLength(100), EmailAddress]
        public string? CustomerEmail { get; set; }

        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Received;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
