namespace MyTicket.DTO.TicketMasterResponses;

public class Image
{
    public string ratio { get; set; }
    public string url { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public bool fallback { get; set; }
    public string attribution { get; set; }
}