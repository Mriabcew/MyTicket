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

    [HttpGet]
    [Route("/{category}")]
    public async Task<List<EventDTO>> GetAllEventsByCategory(string category)
    {
        return await _eventService.GetAllEventsByCategoryAsync(category);
    }

    [HttpGet]
    [Route("/E/{id}")]
    public async Task<EventDTO> GetEventById(string id)
    {
        return await _eventService.getEventById(id);
    }
}