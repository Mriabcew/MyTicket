using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Common.Converters;

public static class EventConverter
{
    public static Event ToEntry(this EventDTO dto)
    {
        return new Event()
        {
            Date = dto.Date,
            Description = dto.Description,
            Id = dto.Id,
            Name = dto.Name
        };
    }
//#todo poprawic
    public static EventDTO ToDTO(this MyTicket.DTO.TicketMasterResponses.Event @event)
    {
        return new EventDTO()
        {
            Date = DateOnly.FromDateTime(@event.dates.start.dateTime),
            Id = @event.id,
            Description = "empty",
            Name = @event.name,
            ImageUrl = "aaa"
            //@event.images[0].url
        };
    }
}