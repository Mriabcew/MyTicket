using MyTicket.Domain;

namespace MyTicket.Services.Interfaces;

public interface IAuthentictaionService
{
    Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
    
}