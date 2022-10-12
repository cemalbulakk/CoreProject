using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Application.Services.Interfaces;

public interface ITokenService
{
    public JwtSecurityToken CreateToken(IEnumerable<Claim> authClaims);
    public string GenerateRefreshToken();
    public ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
}