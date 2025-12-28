using System.Net;
using E_Voter.Api.utils;
using E_Voter.Application.Security;

namespace E_Voter.Api.Middlewares;

public class TokenValidationMiddleware(RequestDelegate next, ITokenValidator tokenValidator, IAuthClientService authClientService)
{
    public async Task InvokeAsync(HttpContext context)
    {
        //if login is called, no need to check this
        var accessToken = context.Request.Cookies[TokenHelper.AccessTokenCookieName];
        // var accessToken = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic2EiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6ImEwZWEzMDVkLTY1MWQtNGNmMS1hZDFmLTFjZDZhZjA2YTkyNyIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL21vYmlsZXBob25lIjoiKzk3Nzk4NDY1MTQ3NDEiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJTVVBFUl9BRE1JTiIsImV4cCI6MTc2NjUxMTc4MywiaXNzIjoiQXV0aGVudGljYXRpb25TZXJ2aWNlIiwiYXVkIjoiRS1Wb3RlciJ9.ojF8zT3yowPina63OAf4BTGERIj2wUHx5Qqp3R6m0fzIA-0n4OU1ZRy3ldHpNLi-kckpD9CQTDE_GsLbuFqmqg";
        var refreshToken = context.Request.Cookies[TokenHelper.RefreshTokenCookieName];

        //no tokens, might access public apis
        if (string.IsNullOrWhiteSpace(accessToken) && string.IsNullOrWhiteSpace(refreshToken))
        {
            await next(context);
            return;
        }
        //valid access token exists
        if (!string.IsNullOrWhiteSpace(accessToken) && !tokenValidator.IsTokenExpired(accessToken))
        {
            context.Request.Headers.Authorization = $"Bearer {accessToken}";
            await next(context);
            return;
        }
        //access token does not exist (is expired) but refresh token exists
        if (!string.IsNullOrWhiteSpace(refreshToken))
        {
            await HandleTokenRefresh(context, refreshToken);
        }
        await next(context);
    }

    private async Task HandleTokenRefresh(HttpContext context, string refreshToken)
    {
        try
        {
            var refreshResponse = await authClientService.RefreshTokens(refreshToken);

            if (refreshResponse is { Success: true, Data: { } authData })
            {
                // Set new tokens in HTTP response cookies and request header
                TokenHelper.SetTokenCookies(context, authData);
                context.Request.Headers.Authorization = $"Bearer {authData.AccessToken}";
            }
            else
            {
                // Refresh failed (e.g., refresh token is revoked or expired)
                TokenHelper.ClearTokenCookies(context);
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                
                // OPTIONAL: Short-circuit the pipeline if refresh failed and we cleared cookies
                // If you want to force the client to relogin immediately, uncomment this:
                // await context.Response.WriteAsync("Unauthorized. Please log in again.");
                // return;
            }
        }
        catch (Exception ex)
        {
            // Log the exception here
            // Clear tokens on any unexpected error during the refresh process
            TokenHelper.ClearTokenCookies(context);
        }
    }

}