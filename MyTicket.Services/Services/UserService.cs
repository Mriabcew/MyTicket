using System.Security.Claims;
using MyTicket.Common.Converters;
using MyTicket.DAL.Interfaces;
using MyTicket.Domain;
using MyTicket.DTO;
using MyTicket.Services.Interfaces;

namespace MyTicket.Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IUploadImageService _uploadImageService;
    public UserService(IUserRepository userRepository,IUploadImageService uploadImageService)
    {
        _userRepository = userRepository;
        _uploadImageService = uploadImageService;
    }
    public async Task AddNew(RegisterDTO userModel)
    {
        var user = new User
        {
            Username = userModel.Username,
            Email = userModel.Email,
            Password = BCrypt.Net.BCrypt.HashPassword(userModel.Password),
            Name = "Not Set",
            Gender = "Not Defined",
            Surname = "Not Set",
            Image = "reactapp/src/assets/profile/defaultProfileImg.jpg",
            BackgroundImage = "reactapp/src/assets/profile/defaultProfileImg.jpg"
        };
        await _userRepository.AddUserAsync(user);
    }
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

    public async Task<bool> SetInfo(int id, string name, string surname, string gender, string password)
    {
        var user = await  _userRepository.GetUserByIdAsync(id);
        var veryfied = Common.Checkers.UserChecker.VerifyPassword(password, user.Password);
        if (veryfied)
        {
            user.Name = name;
            user.Surname = surname;
            user.Gender = gender;
            var userAfterUpdate = await _userRepository.Update(user);
            if (userAfterUpdate.Name == name && userAfterUpdate.Surname == surname)
            {
                return true;
            }
        }

        return false;
    }
    public async Task<bool> ChangeEmail(int id,string newEmail)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        if (user.Email == newEmail)
            return false;
        user.Email = newEmail;
        var userAfterUpdate = await _userRepository.Update(user);
        if (userAfterUpdate.Email == newEmail)
            return true;
        return false;
    }

    public async Task<bool> ChangePassword(int id,string password)
    {
       var user = await _userRepository.GetUserByIdAsync(id);
       user.Password = BCrypt.Net.BCrypt.HashPassword(password);
       var userAfterUpdate = await _userRepository.Update(user);
       if (Common.Checkers.UserChecker.VerifyPassword(password, userAfterUpdate.Password))
           return true;
       return false;
    }

    public async Task<bool> DeleteAccount(int id)
    {
        var user = await _userRepository.GetUserByIdAsync(id);
        return await _userRepository.Delete(user);
    }
    
    public Task<List<Claim>> GetClaimsAsync(User user)
    {
        Claim c = new Claim("MyCos", "MyValue");
        var lis = new List<Claim>();
        lis.Add(c);
        return Task.FromResult(lis);
    }

    public async Task ChangeBackgroundImage(int userId,string cloudinary)
    {
        var user = await _userRepository.GetUserByIdAsync(userId);
        await _userRepository.uploadBackgroundImage(user,cloudinary);
    }

    public async Task ChangeProfileImage(int userId, string cloudinary)
    {
        var user = await _userRepository.GetUserByIdAsync(userId);
        await _userRepository.ChangeImageString(user, cloudinary);

    }
}