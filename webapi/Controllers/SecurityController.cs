using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace webapi.Controllers;
[ApiController]
[Route("/[controller]")]
public class SecurityController : ControllerBase
{
    
    private readonly IUserService _userService;
    private readonly IAuthentictaionService _authentictaionService;
    
    public SecurityController(IUserService userService,IAuthentictaionService authentictaionService)
    {
        _userService = userService;
        _authentictaionService = authentictaionService;
    }

    [HttpPost]
    [Route("Register")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
       await _userService.AddNew(model);

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
            return BadRequest("No user found with the given email address or username");
        }

        var verified = MyTicket.Common.Checkers.UserChecker.VerifyPassword(model.Password, user.Password);
        if (!verified)
        {
            return BadRequest("Password wrong");
        }
        
        return Ok(
            await _authentictaionService.AuthenticateAsync(
                new AuthenticationRequest()
                {
                  EmailorUsername  = model.UsernameOrEmail,
                  Password = model.Password
                }
                )
           );
    }
    [HttpPost]
    [Route("UserInfoSet")]
    public async Task<IActionResult> ChangeUserInfo([FromBody] UserInfoDTO userInfoDto)
    {
        if (await _userService.SetInfo(userInfoDto.Id, userInfoDto.Name, userInfoDto.Surname, userInfoDto.Gender,userInfoDto.Password))
        {
            return Ok("Informations updated");
        }
        else
        {
            return BadRequest("Error data not updated");
        }
    }
    [HttpPost]
    [Route("SetNewPassoword")]
    public async Task<IActionResult> ChangePassword([FromBody] UserPasswordChangeDTO userDto)
    {
        var user = _userService.GetById(userDto.Id).Result;
        var verified = MyTicket.Common.Checkers.UserChecker.VerifyPassword(userDto.OldPassword, user.Password);
        if (verified)
        {
            if (await _userService.ChangePassword(userDto.Id, userDto.NewPassword))
            {
                return Ok();
            }
            else
            {
                return BadRequest("Password change error");
            }
        }
        else
        {
            return BadRequest("Old password wrong");
        }
    }
    
    [HttpPost]
    [Route("SetNewEmail")]
    public async Task<IActionResult> ChangeEmail([FromBody] UserEmailChangeDTO userDto)
    {
        var user = _userService.GetById(userDto.Id).Result;
        var verified = MyTicket.Common.Checkers.UserChecker.VerifyPassword(userDto.Password, user.Password);
        if (verified)
        {
            if (await _userService.ChangeEmail(userDto.Id,userDto.NewEmail))
            {
                return Ok("Email change successfully");
            }
            else
            {
                return BadRequest("Email change error");
            }
        }
        else
        {
            return BadRequest("Password Wrong");
        }
    }
    [Route("DeleteAccount")]
    [HttpPost]
    public async Task<IActionResult> DeleteAccount([FromBody] UserDeleteDTO userDto)
    {
        var user = _userService.GetById(userDto.Id).Result;
        if (MyTicket.Common.Checkers.UserChecker.VerifyPassword(userDto.Password, user.Password))
        {
            if (await _userService.DeleteAccount(userDto.Id))
                return Ok("Account deleted");
            else
            {
                return BadRequest("Account not deleted error");
            }
        }
        else
        {
            return BadRequest("Password wrong");
        }
    }
    
    [Route("BackgroundImage")]
    [HttpPost]
    public async Task<IActionResult> UploadBackgroundImage(string cloudinaryString,int id)
    {
        await _userService.ChangeBackgroundImage(id, cloudinaryString);

        return Ok("Background image uploaded successfully");
    }
    
    [Route("ProfileImage")]
    [HttpPost]
    public async Task<IActionResult> UploadProfileImage(string cloudinaryString,int id)
    {
        await _userService.ChangeProfileImage(id, cloudinaryString);

        return Ok("Profile image uploaded successfully");
    }
}

