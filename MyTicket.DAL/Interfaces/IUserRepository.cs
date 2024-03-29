using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.DAL.Interfaces;

public interface IUserRepository
{ 
    
    Task AddUserAsync(User user);
    
    Task<User>GetUserByEmailAsync(string email);
    Task<User>GetUserByUsernameOrEmail(string email);
    Task<User> GetUserByIdAsync(int id);
    Task<List<User>> GetAllAsync();

    Task<User> Update(User user);

    Task<bool> Delete(User user);
    Task AddEventToUser(EventDTO @event, int id);

    Task ChangeImageString(User user, string newImageString);
    Task UploadBackgroundImage(User user, string cloudinary);
}