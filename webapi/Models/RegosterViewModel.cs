using System.ComponentModel.DataAnnotations;

namespace webapi.Models;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    public string Name { get; set; }
}