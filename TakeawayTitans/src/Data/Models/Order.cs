using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [MaxLength(100)]
        public string? CustomerName { get; set; }

        [MaxLength(20)]
        public string? CustomerPhone { get; set; }

        [MaxLength(100)]
        public string? CustomerEmail { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Received"; // Received, Preparing, Ready

        [MaxLength(100)]
        public string? SessionId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsCompleted { get; set; } = false;

        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
