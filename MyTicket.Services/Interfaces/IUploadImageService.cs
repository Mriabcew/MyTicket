using MyTicket.Domain;

namespace MyTicket.Services.Interfaces;

public interface IUploadImageService
{
    Task uploadBackgroundImage(User user);
    Task uploadProfileImage(User user);
}