using Microsoft.AspNetCore.Mvc;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;

namespace MyTicket.Services.Interfaces;

public interface IEventService
{ 
    Task<List<EventDTO>> GetAllEventsByCategoryAsync(string category);

    Task<EventDTO> GetEventById(string Id);

    Task<List<EventDTO>> GetAllEventsByUserId(int id);

    Task AddEventToUserById(int id, string eventId);

    Task<List<EventDTO>> GetAllEventsByDateForUser(int id, string Date);
    Task RemoveEventFromUser(int userId, string eventId);
}