using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Data.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CustomerName { get; set; } = default!;

        [Required]
        [MaxLength(20)]
        public string CustomerPhone { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        public string CustomerEmail { get; set; } = default!;

        // New status field
        [Required]
        [MaxLength(20)]
        public string Status { get; set; } = "Received"; // Received, Preparing, Ready

        // Navigation property
        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
