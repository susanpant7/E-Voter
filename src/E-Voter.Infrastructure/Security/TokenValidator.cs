using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using E_Voter.Application.AppSettings;
using E_Voter.Application.Security;
using Microsoft.IdentityModel.Tokens;

namespace E_Voter.Infrastructure.Security
{
    public class TokenValidator(AppSetting appSetting) : ITokenValidator
    {
        private readonly string _secretKey = appSetting.AuthSetting.Secret ?? throw new ArgumentNullException();
        private readonly string _issuer = appSetting.AuthSetting.Issuer  ?? throw new ArgumentNullException();
        private readonly string _audience = appSetting.AuthSetting.Audience ?? throw new ArgumentNullException();

        public bool IsTokenExpired(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                return jwtToken.ValidTo < DateTime.UtcNow;
            }
            catch
            {
                return true;
            }
        }

        public ClaimsPrincipal? ValidateToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = _issuer,
                    ValidAudience = _audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey))
                };

                var principal = tokenHandler.ValidateToken(token, validationParameters, out _);
                return principal;
            }
            catch
            {
                return null;
            }
        }
    }
}