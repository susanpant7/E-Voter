using System.Security.Claims;

namespace E_Voter.Application.Security;

public interface ITokenValidator
{
    bool IsTokenExpired(string token);
    ClaimsPrincipal? ValidateToken(string token);
}