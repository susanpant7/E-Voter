using E_Voter.Application.Shared;

namespace E_Voter.Application.Security;

public interface IAuthClientService
{
    Task<ApiResponse<AuthResponse?>?> Login(LoginRequest request);
    Task<ApiResponse<AuthResponse?>?> RefreshTokens(string refreshToken);
}