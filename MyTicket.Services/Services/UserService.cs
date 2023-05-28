using MyTicket.Common.Converters;
using MyTicket.DAL.Interfaces;
using MyTicket.DAL.Repositories;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace MyTicket.Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async void AddNewUser(RegisterDTO userModel)
    {
        var user = new User
        {
            Username = userModel.Username,
            Email = userModel.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(userModel.Password),
            Name = "Not Set",
            Gender = "NotDefined",
            Surname = "Not Set",
            Image = "reactapp/images/uploads/profileImages/defaultProfileImg.jpg"
        };
        await _userRepository.AddUserAsync(user);
    }
    //
    public async Task<UserDTO> GetByEmailOrUsername(string email)
    {
        var user = await _userRepository.GetUserByUsernameOrEmail(email);
        return user.ToDTO();
    }

    public async Task<UserDTO> GetById(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        return user.ToDTO();
    }
}