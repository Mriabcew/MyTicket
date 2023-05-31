using System.Security.Claims;
using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Services.Interfaces;

public interface IUserService
{
    Task AddNew(RegisterDTO userModel);

    Task<UserDTO> GetByEmailOrUsername(string email);

    Task<UserDTO> GetById(int id);

    Task<bool> SetInfo(int id, string name, string surname,string gender, string password);

    Task<bool> ChangeEmail(int id, string newEmail);

    Task<bool> ChangePassword(int id, string password);

    Task<bool> DeleteAccount(int id);

    Task<List<Claim>> GetClaimsAsync(User user);


    Task ChangeBackgroundImage(int userId, string cloudinary);
    Task ChangeProfileImage(int id,string cloudinary);
}