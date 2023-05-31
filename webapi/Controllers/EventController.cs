using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTicket.DTO;
using MyTicket.DTO.TicketMasterResponses;
using MyTicket.Services.Interfaces;

namespace webapi.Controllers;

[Controller]
[Route("Events")]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;

    public EventController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [Authorize]
    [HttpGet]
    [Route("/{category}")]
    public async Task<List<EventDTO>> GetAllEventsByCategory(string category)
    {
        return await _eventService.GetAllEventsByCategoryAsync(category);
    }

    [Authorize]
    [HttpGet]
    [Route("/E/{id}")]
    public async Task<EventDTO> GetEventById(string id)
    {
        return await _eventService.GetEventById(id);
    }


    [HttpGet]
    [Route("MyTickets/{id}")]
    public async Task<List<EventDTO>> GetEventsByUserId(int id)
    {
        return await _eventService.GetAllEventsByUserId(id);
    }

    [HttpPost]
    [Route("MyTickets/add/{id}")]
    public async Task AddEventToUserById(int id, string eventId)
    {
        await _eventService.AddEventToUserById(id, eventId);
    }

    [HttpGet]
    [Route("Calendar/events/{date}")]
    public async Task<List<EventDTO>> GetAllEventsByDateForUser(int id ,string date)
    {
        return await _eventService.GetAllEventsByDateForUser(id, date);
    }

    [HttpPost]
    [Route("MyTickets/remove/{id}")]
    public async Task RemoveEventByUserId(int id, string eventId)
    {
        await _eventService.RemoveEventFromUser(id, eventId);
    }

}