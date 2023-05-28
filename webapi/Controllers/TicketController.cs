using Microsoft.AspNetCore.Mvc;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class TicketController: ControllerBase
{
    private readonly ITicketService _ticketService;
    
    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<List<TicketDTO>> GetTicketsByUserId(int id)
    {
        return await _ticketService.GetTicketsByUserId(id);
    }

}
