namespace MyTicket.DTO.TicketMasterResponses;

public class Embedded
{
    public List<Event> events { get; set; }
    public List<Venue> venues { get; set; }
    public List<Attraction> attractions { get; set; }
}