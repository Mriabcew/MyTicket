namespace MyTicket.DTO.TicketMasterResponses;

public class Dates
{
    public Start start { get; set; }
    public string timezone { get; set; }
    public Status status { get; set; }
    public bool spanMultipleDays { get; set; }
}