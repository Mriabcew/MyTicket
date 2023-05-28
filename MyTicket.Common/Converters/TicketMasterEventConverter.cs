using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;

namespace MyTicket.Common.Converters;

public static class TicketMasterEventConverter
{
    public static EventDTO toDTO(this Event @event)
    {
        return new EventDTO()
        {
            Date = DateOnly.FromDateTime(@event.dates.start.dateTime.Date),
            Description = "empty",
            Id = @event.id,
            Name = @event.name,
            ImageUrl = @event.images.FirstOrDefault(i=>i.width>1000).url
        };
    }

}