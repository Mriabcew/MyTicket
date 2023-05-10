using System.ComponentModel.DataAnnotations;

namespace webapi.Models;
//SKONCZONE
public class Ticket
{
    public int Id { get; set; }
    
    public DateTime PurchaseDate { get; set; }
    [Required]
    public decimal price { get; set; }
    
    [Required]
    public int SeatNumber { get; set; }
    [Required]
    public string Row { get; set; }
    
    [Required]
    public string Sector { get; set; }
    
    [Required]
    public string Status { get; set; }
    
    public string QRCode { get; set; }
    
}