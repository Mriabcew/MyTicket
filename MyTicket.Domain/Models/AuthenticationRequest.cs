namespace MyTicket.Domain;

public class AuthenticationRequest
{
    public string EmailorUsername { get; set; }
    public string Password { get; set; }
}