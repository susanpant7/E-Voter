using E_Voter.Application.Shared;

namespace E_Voter.Application.Security;

public interface ILoginService
{
    Task<ApiResponse<AuthResponse?>?> LoginAsync(LoginRequest request);
}