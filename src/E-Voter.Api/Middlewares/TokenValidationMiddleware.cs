using System.Net;
using E_Voter.Api.utils;
using E_Voter.Application.Security;

namespace E_Voter.Api.Middlewares;

public class TokenValidationMiddleware(RequestDelegate next, ITokenValidator tokenValidator, IAuthClientService authClientService)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var accessToken = context.Request.Cookies[TokenHelper.AccessTokenCookieName];
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