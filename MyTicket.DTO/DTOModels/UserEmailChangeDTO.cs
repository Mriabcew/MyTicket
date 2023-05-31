namespace MyTicket.DTO;

public class UserEmailChangeDTO
{
    public int Id { get; set; }
    public string Password { get; set; }
    public string OldEmail { get; set; }
    public string NewEmail { get; set; }

}