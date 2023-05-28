using MyTicket.Domain;
using MyTicket.DTO;

namespace MyTicket.Common.Converters;

public static class UserConverter
{
    public static User ToEntry(this UserDTO dto)
    {
        return new User()
        {
            Email = dto.Email,
            Gender = dto.Gender,
            Id = dto.Id,
            Image = dto.Image,
            Name = dto.Name,
            Password = dto.Password,
            Surname = dto.Surname,
            Username = dto.Username
        };
    }
    public static UserDTO ToDTO(this User user)
    {
        return new UserDTO()
        {
            Email = user.Email,
            Gender = user.Gender,
            Id = user.Id,
            Image = user.Image,
            Name = user.Name,
            Password = user.Password,
            Surname = user.Surname,
            Username = user.Username
        };
    }
    
}