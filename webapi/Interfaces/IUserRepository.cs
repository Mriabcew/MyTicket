using webapi.Models;

namespace webapi.Interfaces;

public interface IUserRepository
{ 
    Task<User>GetUserByEmail(string email);
    Task AddUser(User user);
}