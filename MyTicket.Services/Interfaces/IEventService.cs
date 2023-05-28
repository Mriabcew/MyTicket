using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;

namespace MyTicket.Services.Interfaces;

public interface IEventService
{ 
    Task<List<EventDTO>> GetAllEventsByCategoryAsync(string category);

    Task<EventDTO> getEventById(string Id);
}