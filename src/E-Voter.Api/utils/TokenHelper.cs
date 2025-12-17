using E_Voter.Application.Security;

namespace E_Voter.Api.utils;

public static class TokenHelper
{
    public const string AccessTokenCookieName = "AccessToken";
    public const string RefreshTokenCookieName = "RefreshToken";
    public static void SetTokenCookies(HttpContext context, AuthResponse authResponse)
    {
        // Define common cookie options for security
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true, // Client-side JavaScript cannot access the cookies
            Secure = true,   // Only sent over HTTPS
            SameSite = SameSiteMode.Strict
        };

        context.Response.Cookies.Append(AccessTokenCookieName, authResponse.AccessToken, new CookieOptions(cookieOptions)
        {
            Expires = DateTimeOffset.UtcNow.AddMinutes(authResponse.AccessTokenExpiryInMinute)
        });

        context.Response.Cookies.Append(RefreshTokenCookieName, authResponse.RefreshToken, new CookieOptions(cookieOptions)
        {
            Expires = DateTimeOffset.UtcNow.AddDays(authResponse.RefreshTokenExpiryInDays)
        });
    }
    
    public static void ClearTokenCookies(HttpContext context)
    {
        context.Response.Cookies.Delete(AccessTokenCookieName);
        context.Response.Cookies.Delete(RefreshTokenCookieName);
    }
}