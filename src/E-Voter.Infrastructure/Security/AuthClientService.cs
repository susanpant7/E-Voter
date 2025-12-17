using System.Net.Http.Json;
using E_Voter.Application.Security;
using E_Voter.Application.Shared;
using Microsoft.Extensions.Logging;

namespace E_Voter.Infrastructure.Security;

public class AuthClientService(HttpClient httpClient, ILogger<AuthClientService> logger) : IAuthClientService
{
    public async Task<ApiResponse<AuthResponse?>?> Login(LoginRequest loginRequest)
    {
        try
        {
            var response = await httpClient.PostAsJsonAsync("api/auth/login", loginRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ApiResponse<AuthResponse?>>();
            }

            logger.LogWarning("Login failed with status code: {StatusCode}", response.StatusCode);
            return null;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error calling auth service for token refresh");
            return null;
        }
    }
    
    public async Task<ApiResponse<AuthResponse?>?> RefreshTokens(string refreshToken)
    {
        try
        {
            var request = new RefreshTokenRequest { RefreshToken = refreshToken };

            var response = await httpClient.PostAsJsonAsync("api/auth/refresh", request);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ApiResponse<AuthResponse?>>();
            }

            logger.LogWarning("Token refresh failed with status code: {StatusCode}", response.StatusCode);
            return null;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error calling auth service for token refresh");
            return null;
        }
    }
}