using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required, EmailAddress]
    public string Email { get; set; } = string.Empty;
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
    [Required]
    public string PasswordHash { get; set; } = string.Empty;
    [Required]
    public string FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; }
    [Required]
    public string Role { get; set; } = "User";
    public string? ImageUrl { get; set; }
    [Required, DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
}