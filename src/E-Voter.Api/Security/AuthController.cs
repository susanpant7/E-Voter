using E_Voter.Api.utils;
using E_Voter.Application.Security;
using E_Voter.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.Security;

[ApiController]
[Route("api/auth")]
public class AuthController(ILoginService loginService) : ControllerBase
{
    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginRequest request)
    {
        var response = await loginService.LoginAsync(request);
        if (response == null || response?.Success == false || response?.Data == null)
        {
            return BadRequest(ApiResponse<AuthResponse>.ErrorResponse("The response from authentication service is null"));
        }
        TokenHelper.SetTokenCookies(HttpContext, response?.Data!);
        response?.Data?.RefreshToken = string.Empty;
        return Ok(response);
    }
    
    [HttpPost("logout")]
    public ActionResult Logout()
    {
        TokenHelper.ClearTokenCookies(HttpContext);
        return Ok(ApiResponse<string>.SuccessResponse("User logged out"));
    }
}