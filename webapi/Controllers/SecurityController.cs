using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Interfaces;
using webapi.Models;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class SecurityController : ControllerBase
{
    
    private readonly IUserRepository _userRepository;
    
    public SecurityController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost]
    [Route("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
//#TODO NIE WIEM CZY TO PRAWIDLOWE
        var user = new User
        {
            Username = model.Username,
            Email = model.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(model.Password),
            Name = "Not Set",
            Gender = "NotDefined",
            Surname = "Not Set",
            Image = "reactapp/images/uploads/profileImages/defaultProfileImg.jpg"
        };

        await _userRepository.AddUserAsync(user);

        return Ok();
    }
//#TODO OGARNAC KODY BLEDOW I PRZETLOMACZYC NA ANG
    [HttpPost]
    [Route("Login")]
    public async Task<IActionResult> Login([FromBody] LoginViewModel model)
    {
        var usernameOrEmail = model.UsernameOrEmail;
        var user = await _userRepository.GetUserByUsernameOrEmail(usernameOrEmail);
        if (user == null)
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

