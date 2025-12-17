using E_Voter.Application.Security;
using E_Voter.Application.Shared;

namespace E_Voter.Infrastructure.Security;

public class LoginService (IAuthClientService authClientService) : ILoginService
{
    public async Task<ApiResponse<AuthResponse?>?> LoginAsync(LoginRequest request)
    {
        var refreshTokenResponse = await authClientService.Login(request);
        return refreshTokenResponse;
    }
}