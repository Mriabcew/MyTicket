using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Common.Converters;

public static class EventConverter
{
    public static Event ToEntry(this EventDTO dto)
    {
        return new Event()
        {
            Id = dto.Id,
            Date = dto.Date,
            Description = dto.Description,
            TicketMasterId = dto.TicketMasterId,
            Name = dto.Name
        };
    }
    public static EventDTO ToDTO(this Event @event)
    {
        return new EventDTO()
        {
            Date = @event.Date,
            Id = @event.Id,
            Description = @event.Description,
            Name = @event.Name,
            ImageUrl = @event.Url
        };
    }
}