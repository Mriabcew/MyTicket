using System.ComponentModel.DataAnnotations;

namespace MyTicket.Domain;

public class Event
{
    public int Id { get; set; }
    public string  TicketMasterId { get; set; }

    public string Name { get; set; }
   
    public string Description { get; set; }

    public string Type { get; set; }
    
    public string Url { get; set; }

    public DateOnly Date { get; set; }

    public int UserId { get; set; }
    
}