namespace E_Voter.Application.Security;

public interface IAuthServiceClient
{
    Task<TokenResponse?> RefreshTokensAsync(string refreshToken);
}