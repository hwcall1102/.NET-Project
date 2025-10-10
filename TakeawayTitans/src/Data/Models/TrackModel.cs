using System.ComponentModel.DataAnnotations;

public class TrackModel
{
    [Required(AllowEmptyStrings = false), EmailAddress]
    public string? Email { get; set; }
    [Required(AllowEmptyStrings = false)]
    public string? OrderCode { get; set; }
}