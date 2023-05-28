namespace MyTicket.DTO;

public class EventDTO
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateOnly Date { get; set; }
    
    public string ImageUrl { get; set; }
}