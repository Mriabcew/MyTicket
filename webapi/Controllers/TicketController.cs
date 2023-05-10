using Microsoft.AspNetCore.Mvc;
using webapi.Repositories;

namespace webapi.Controllers;

public class TicketController: ControllerBase
{
    private readonly TicketRepository _ticketReposiotry;
    
    public TicketController(TicketRepository ticketReposiotry)
    {
        _ticketReposiotry = ticketReposiotry;
    }

}