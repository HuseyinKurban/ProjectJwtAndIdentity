using Microsoft.IdentityModel.Tokens;
using ProjectJwtAndIdentity.Models;
using System.Security.Claims;
using System.Text;

namespace ProjectJwtAndIdentity.JWTTools
{
    public class JwtTokenGenerator
    {
        public static TokenResponseModel GenerateToken(ResultAppUser resultAppUser)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, resultAppUser.Name));
            claims.Add(new Claim(ClaimTypes.Surname, resultAppUser.Surname));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, resultAppUser.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Email, resultAppUser.Email));
            claims.Add(new Claim("Username", resultAppUser.Username));
            claims.Add(new Claim("City", resultAppUser.City));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key));
        }
    }
}
