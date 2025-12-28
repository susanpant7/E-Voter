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
            // var authResponse = new AuthResponse()
            // {
            //     AccessToken =
            //         "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic2EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImEwZWEzMDVkLTY1MWQtNGNmMS1hZDFmLTFjZDZhZjA2YTkyNyIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL21vYmlsZXBob25lIjoiKzk3Nzk4NDY1MTQ3NDEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJTVVBFUl9BRE1JTiIsImV4cCI6MTc2Njg4NDI1MSwiaXNzIjoiQXV0aGVudGljYXRpb25TZXJ2aWNlIiwiYXVkIjoiRS1Wb3RlciJ9.lWWYsGyg-3tiYQI3ftdO4Z0LAbnsKNRDRv7TRNoH7nC4NIBwILBlrZ4qIlCD-zeKBCP3edewa7RFDPV6jmWVZg",
            //     AccessTokenExpiryInMinute = 1400,
            //     RefreshToken = "DWO%2FmANRl%2B0x6MNNiWwGSZiWdL10p5RuATuAzzr%2FBHk%3D",
            //     RefreshTokenExpiryInDays = 7
            // };
            // return ApiResponse<AuthResponse>.SuccessResponse(authResponse);
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