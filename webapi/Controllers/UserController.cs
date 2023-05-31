using Microsoft.AspNetCore.Mvc;
using MyTicket.DAL.Interfaces;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetUser(int id)
    {
        var user = await _userService.GetById(id);
        if (user == null)
        {
            return NotFound();
        }

        return user;
    }
    
    
}