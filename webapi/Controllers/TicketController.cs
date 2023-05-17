using Microsoft.AspNetCore.Mvc;
using webapi.Interfaces;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class TicketController: ControllerBase
{
    private readonly ITicketRepository _ticketReposiotry;
    
    public TicketController(ITicketRepository ticketReposiotry)
    {
        _ticketReposiotry = ticketReposiotry;
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<List<Ticket>> GetTicketsByUserId(int id)
    {
        return await _ticketReposiotry.GetTicketsByUserId(id);
    }

}
