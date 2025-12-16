using E_Voter.Api.Common;
using E_Voter.Api.Security;
using E_Voter.Application.Voter;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.Voter;

[Route("api/voters")]
[ApiController]
public class VoterController (IVoterService voterService) : ControllerBase
{
    [HttpGet("profile")]
    public async Task<ActionResult<ApiResponse<object>>> Index()
    {
        string mobileNumber = User.GetMobileNumber();
        string username = User.GetUsername();

        if (string.IsNullOrEmpty(mobileNumber))
        {
            return ApiResponse<object>.ErrorResponse("Mobile number not found in user claims.");
        }

        var profile = await voterService.GetVoterProfileAsync(mobileNumber);

        if (profile == null)
        {
            return ApiResponse<object>.ErrorResponse("Voter profile not found.");
        }

        return ApiResponse<object>.SuccessResponse(profile);
    }
}