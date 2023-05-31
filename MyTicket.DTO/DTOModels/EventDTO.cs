namespace MyTicket.DTO;

public class EventDTO
{
    public int Id { get; set; }
    public string TicketMasterId { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public DateOnly Date { get; set; }
    
    public string Type { get; set; }
    
    public string ImageUrl { get; set; }
}