using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace TakeawayTitans.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage ="Email address required"), EmailAddress(ErrorMessage ="Invalid Email format")]
    public string Email { get; set; } = string.Empty;
    [NotMapped]
    [MinLength(6)]
    public string Password { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = "Unknown";
    public string? LastName { get; set; }
    public UserRole Role { get; set; } = UserRole.User;
    public string? ImageUrl { get; set; }
    [Required, DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}

public enum UserRole
{
    User,
    Admin
}