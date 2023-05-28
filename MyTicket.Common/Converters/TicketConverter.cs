using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Common.Converters;

public static class TicketConverter
{
    public static Ticket ToEntry(this TicketDTO dto)
    {
        return new Ticket()
        {
            Id = dto.Id,
            price = dto.Price,
            PurchaseDate = dto.PurchaseDate,
            QRCode = dto.QRCode,
            Row = dto.Row,
            SeatNumber = dto.SeatNumber,
            Sector = dto.Sector,
            Status = dto.Status
        };
    }
    
    public static TicketDTO ToDTO(this Ticket ticket)
    {
        return new TicketDTO()
        {
            Id = ticket.Id,
            Price = ticket.price,
            PurchaseDate = ticket.PurchaseDate,
            QRCode = ticket.QRCode,
            Row = ticket.Row,
            SeatNumber = ticket.SeatNumber,
            Sector = ticket.Sector,
            Status = ticket.Status
        };
    }
}