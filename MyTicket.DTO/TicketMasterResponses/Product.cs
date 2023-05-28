namespace MyTicket.DTO.TicketMasterResponses;

public class Product
{
    public string name { get; set; }
    public string id { get; set; }
    public string url { get; set; }
    public string type { get; set; }
    public List<Classification> classifications { get; set; }
}