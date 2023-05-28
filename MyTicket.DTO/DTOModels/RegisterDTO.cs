using System.ComponentModel.DataAnnotations;

namespace MyTicket.DTO;

public class RegisterDTO
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    public string Username { get; set; }
}