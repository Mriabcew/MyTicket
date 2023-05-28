using Microsoft.AspNetCore.Mvc;
using MyTicket.DAL.Interfaces;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;
using MyTicket.Services.Services;


namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class SecurityController : ControllerBase
{
    
    private readonly IUserService _userService;
    
    public SecurityController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    [Route("Register")]
    public IActionResult Register([FromBody] RegisterDTO model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        _userService.AddNewUser(model);

        return Ok();
    }
    
    [HttpPost]
    [Route("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDTO model)
    {
        var usernameOrEmail = model.UsernameOrEmail;
        var user = await _userService.GetByEmailOrUsername(usernameOrEmail);
        if (user is null)
        {
            return BadRequest("NIE ZNALEZIONO UŻYTKOWNIKA O PODANYM ADRESIE EMAIL LUB NAZWIE UZYTKOWNIKA");
        }

        var verified = BCrypt.Net.BCrypt.Verify(model.Password, user.Password);
        if (!verified)
        {
            return BadRequest("HASŁO NIEPRAWIDŁOWE");
        }
        
        return Ok(
            new
            {
                userId = user.Id,
                email = user.Email,
                username = user.Username
            });
    }
    
}

