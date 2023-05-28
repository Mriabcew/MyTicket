using MyTicket.DTO;

namespace MyTicket.Services.Interfaces;

public interface IUserService
{
    void AddNewUser(RegisterDTO userModel);

    Task<UserDTO> GetByEmailOrUsername(string email);

    Task<UserDTO> GetById(int id);

}