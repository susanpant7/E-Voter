using System.Security.Claims;
using E_Voter.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.Security;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    // The [Authorize] attribute ensures that:
    // 1. A valid AccessToken was sent in the request (via the HttpOnly cookie).
    // 2. The token was successfully validated by the JWT middleware (configured in Program.cs).
    [HttpGet("me")]
    [Authorize]
    [ProducesResponseType(typeof(ApiResponse<CurrentUser>), 200)]
    public IActionResult GetCurrentUser()
    {
        // The token is validated, and claims are populated in HttpContext.User
        var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var emailClaim = User.FindFirst(ClaimTypes.Email)?.Value;
        var roles = User.FindAll(ClaimTypes.Role).Select(c => c.Value).ToList();


        var userDto = new CurrentUser
        {
            Name = User.GetUsername()??throw new InvalidOperationException(),
            UserId = User.GetUserId()??throw new InvalidOperationException(),
            Roles = roles
        };
        // Return the clean user object wrapped in ApiResponse
        return Ok(ApiResponse<CurrentUser>.SuccessResponse(userDto));
    }
}