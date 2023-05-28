namespace MyTicket.DTO.TicketMasterResponses;

public class Event
{
    public string name { get; set; }
    public string type { get; set; }
    public string id { get; set; }
    public bool test { get; set; }
    public string url { get; set; }
    public string locale { get; set; }
    public List<Image> images { get; set; }
    public Sales sales { get; set; }
    public Dates dates { get; set; }
    public List<Classification> classifications { get; set; }
    public Promoter promoter { get; set; }
    public List<Promoter> promoters { get; set; }
    public List<PriceRange> priceRanges { get; set; }
    public Seatmap seatmap { get; set; }
    public Links _links { get; set; }
    public Embedded _embedded { get; set; }
    public Accessibility accessibility { get; set; }
    public TicketLimit ticketLimit { get; set; }
    public AgeRestrictions ageRestrictions { get; set; }
    public Ticketing ticketing { get; set; }
    public string pleaseNote { get; set; }
    public List<Product> products { get; set; }
    public string info { get; set; }
    public DoorsTimes doorsTimes { get; set; }
    public List<Outlet> outlets { get; set; }
}