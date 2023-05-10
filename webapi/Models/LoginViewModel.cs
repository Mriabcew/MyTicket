using System.ComponentModel.DataAnnotations;

namespace webapi.Models;

public class LoginViewModel
{
    [Required]
    public string UsernameOrEmail { get; set; }
    [Required]
    public string Password { get; set; }
    
}