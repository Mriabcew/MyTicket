using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Interfaces;
using webapi.Models;
using webapi.Repositories;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class UserController : ControllerBase
{
    private const int MaxFileSize = 2048 * 2048;
    private const string UploadDirectory = "/../reactapp/images/uploads/profileImages";
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        return user;
    }
    
}