using E_Voter.Api.Common;
using E_Voter.Api.Security;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.Profile;

[ApiController]
[Route("api/profile")]
public class ProfileController : ControllerBase
{
    // GET
    public ActionResult<ApiResponse<object>> Index()
    {
        var myProfile = new
        {
            Name = User.GetUsername(),
            Email = "test email",
            mobileNumber = User.GetMobileNumber(),
        };
        return ApiResponse<object>.SuccessResponse(myProfile);
    }
}