namespace E_Voter.Application.Security;

public class AuthResponse
{
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty;
    public int AccessTokenExpiryInMinute { get; set; }
    public int RefreshTokenExpiryInDays { get; set; }
}