using System.ComponentModel.DataAnnotations;
namespace MyTicket.Domain;

public class User
{
    
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Gender { get; set; }
    public string Image { get; set; }
    public string BackgroundImage { get; set; }
    
    public List<Event> EventsList { get; set; }
}