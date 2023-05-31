namespace MyTicket.DTO;

public class UserPasswordChangeDTO
{
    public int Id { get; set; }
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
}