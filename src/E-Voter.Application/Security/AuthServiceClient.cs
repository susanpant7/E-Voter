using System.Net.Http.Json;
using Microsoft.Extensions.Logging;

namespace E_Voter.Application.Security;

public class AuthServiceClient(HttpClient httpClient, ILogger<AuthServiceClient> logger) : IAuthServiceClient
{
    public async Task<TokenResponse?> RefreshTokensAsync(string refreshToken)
    {
        try
        {
            var request = new RefreshTokenRequest { RefreshToken = refreshToken };
            
            var response = await httpClient.PostAsJsonAsync("/api/auth/refresh", request);
            
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TokenResponse>();
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