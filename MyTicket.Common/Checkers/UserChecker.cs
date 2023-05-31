namespace MyTicket.Common.Checkers;

public static class UserChecker
{
    public static bool VerifyPassword(string password,string hashPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashPassword);
    }
}