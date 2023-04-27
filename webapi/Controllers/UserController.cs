using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Data;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var user = new User
        {
            Name = model.Name,
            Email = model.Email,
            Password = model.Password
            //#TODO jeśli używasz BCrypt.Net, należy zainstalować nuget package BCrypt.Net-Next
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok();
    }
}