using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

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
        public Order()
        {
            OrderCode = GenerateOrderCode();
        }

        public int OrderId { get; set; }

        [Required]
        [StringLength(4, MinimumLength = 4)]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Order code must be 4 digits.")]
        public string OrderCode { get; set; }

        [MaxLength(100)]
        public string? CustomerName { get; set; }

        [MaxLength(20), Phone]
        public string? CustomerPhone { get; set; }

        [MaxLength(100), EmailAddress]
        public string? CustomerEmail { get; set; }

        private OrderStatus _status = OrderStatus.Received;

        [Required]
        public OrderStatus Status
        {
            get => _status;
            set
            {
                if (_status == value)
                {
                    return;
                }

                _status = value;
                var now = DateTime.UtcNow;

                // Capture first time each lifecycle stage is reached.
                switch (value)
                {
                    case OrderStatus.Received:
                        ReceivedAt ??= now;
                        break;
                    case OrderStatus.Preparing:
                        PreparingAt ??= now;
                        break;
                    case OrderStatus.Ready:
                        ReadyAt ??= now;
                        break;
                    case OrderStatus.Completed:
                        CompletedAt ??= now;
                        break;
                    case OrderStatus.Canceled:
                        CanceledAt ??= now;
                        break;
                }
            }
        }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ReceivedAt { get; set; } = DateTime.UtcNow;

        public DateTime? PreparingAt { get; set; }

        public DateTime? ReadyAt { get; set; }

        public DateTime? CompletedAt { get; set; }

        public DateTime? CanceledAt { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new();

        private static string GenerateOrderCode() =>
            RandomNumberGenerator.GetInt32(0, 10000).ToString("D4");
    }
}
