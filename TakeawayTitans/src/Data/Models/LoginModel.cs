using System;
using System.ComponentModel.DataAnnotations;

namespace TakeawayTitans.Models;

public class LoginModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide email"), EmailAddress]
    public string? Email { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
    public string? Password { get; set; }
}