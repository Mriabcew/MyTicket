namespace MyTicket.DTO.TicketMasterResponses;

public class Classification
{
    public bool primary { get; set; }
    public Segment segment { get; set; }
    public Genre genre { get; set; }
    public SubGenre subGenre { get; set; }
    public bool family { get; set; }
    public Type type { get; set; }
    public SubType subType { get; set; }
}