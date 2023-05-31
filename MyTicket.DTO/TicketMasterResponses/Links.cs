namespace MyTicket.DTO.TicketMasterResponses;

public class Links
{
    public Self self { get; set; }
    public List<Attraction> attractions { get; set; }
    public List<Venue> venues { get; set; }
    public Prev prev { get; set; }
    public First first { get; set; }
    public Next next { get; set; }
    public Last last { get; set; }
}