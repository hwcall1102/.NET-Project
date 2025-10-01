using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FName { get; set; } = default!;

        [Required]
        [MaxLength(50)]
        public string LName { get; set; } = default!;

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;

        [Required]
        [MaxLength(20)]
        public string Type { get; set; } = "admin"; // all users are admin for now
    }
}
