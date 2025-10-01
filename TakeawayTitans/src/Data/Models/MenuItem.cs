using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Data.Models
{
    public class MenuItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = default!;

        [Range(0, 1000)]
        public decimal Price { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = default!;

        [MaxLength(200)]
        public string ImageUrl { get; set; } = default!;
    }
}
