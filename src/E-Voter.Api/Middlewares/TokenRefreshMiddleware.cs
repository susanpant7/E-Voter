namespace E_Voter.Api.Middlewares;

public class TokenRefreshMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var accessToken = context.Request.Cookies["AccessToken"];
        var refreshToken = context.Request.Cookies["RefreshToken"];

        // Check if access token is expired but refresh token exists
        if (!string.IsNullOrWhiteSpace(accessToken) &&
            !string.IsNullOrWhiteSpace(refreshToken)
            )
        {
            try
            {
                
            }
            catch (Exception)
            {
                // If refresh fails, clear cookies and let request proceed
                ClearTokenCookies(context);
            }
        }

        await next(context);
    }

    private void SetTokenCookies(HttpContext context, string accessToken, string refreshToken)
    {
        // Access Token - short lived (15 minutes)
        context.Response.Cookies.Append("AccessToken", accessToken, new CookieOptions
        {
            HttpOnly = true,
            Secure = true, // HTTPS only
            SameSite = SameSiteMode.Strict,
            Expires = DateTimeOffset.UtcNow.AddMinutes(15)
        });

        // Refresh Token - longer lived (7 days)
        context.Response.Cookies.Append("RefreshToken", refreshToken, new CookieOptions
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = DateTimeOffset.UtcNow.AddDays(7)
        });
    }

    private void ClearTokenCookies(HttpContext context)
    {
        context.Response.Cookies.Delete("AccessToken");
        context.Response.Cookies.Delete("RefreshToken");
    }
}