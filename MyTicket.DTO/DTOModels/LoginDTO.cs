using System.ComponentModel.DataAnnotations;

namespace MyTicket.DTO;

public class LoginDTO
{
    [Required]
    public string UsernameOrEmail { get; set; }
    [Required]
    public string Password { get; set; }
    
}