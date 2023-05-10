using System.ComponentModel.DataAnnotations;

namespace webapi.Models;
//SKONCZONE
public class Event
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
   
    public string Description { get; set; }
    [Required]
    public string Type { get; set; }
    
    public string Url { get; set; }
    [Required]
    public DateOnly Date { get; set; }
    [Required]
    public TimeOnly Time { get; set; }
    
    public TimeSpan Duration { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; }


}