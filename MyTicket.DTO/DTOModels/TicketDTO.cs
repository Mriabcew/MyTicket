namespace MyTicket.DTO;

public class TicketDTO
{
    public int Id { get; set; }
    
    public DateTime PurchaseDate { get; set; }

    public decimal Price { get; set; } 
    
    public int SeatNumber { get; set; }

    public string Row { get; set; }
    
    public string Sector { get; set; }

    public string Status { get; set; }
    
    public string QRCode { get; set; }
}