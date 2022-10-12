using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Application.Features.Dtos.Auth;
using Application.Services.Interfaces;
using Common.Dtos;
using Common.Helpers;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Services.Concrete;

public class AuthService : IAuthService
{
    private readonly IUserService _userService;
    private readonly IUserRoleService _userRoleService;
    private readonly ITokenService _tokenService;
    private readonly IConfiguration _configuration;

    public AuthService(IUserService userService, IUserRoleService userRoleService, ITokenService tokenService, IConfiguration configuration)
    {
        _userService = userService;
        _userRoleService = userRoleService;
        _tokenService = tokenService;
        _configuration = configuration;
    }

    public async Task<Response<TokenInfo>> Auth(AuthDto authDto)
    {
        var user = await _userService.GetAsync(x => x.Email.Equals(authDto.Email));
        if (user == null) return Response<TokenInfo>.Fail("Username or password is wrong.", 400);

        var validPassword = ValidPassword(authDto.Password, user);
        if (!validPassword) return Response<TokenInfo>.Fail("Username or password is wrong.", 400);

        #region Find User Roles

        var userRoles = _userRoleService.GetAllAsync(x => x.UserId.Equals(user.Id),
            include: x => x.Include(x1 => x1.RoleGroup).ThenInclude(x1 => x1.Roles)); // Find user all roles

        #endregion

        #region Create Token

        var authClaims = new List<Claim>
        {
            new(ClaimTypes.Email, user.Email),
            new(ClaimTypes.NameIdentifier, user.Id),
            new(ClaimTypes.Name, user.UserName),
            new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        foreach (var userRole in userRoles)
        {
            authClaims.AddRange(userRole.RoleGroup.Roles.Select(x => new Claim(ClaimTypes.Role, x.Name)));
        }

        var token = _tokenService.CreateToken(authClaims);
        var refreshToken = _tokenService.GenerateRefreshToken();

        #endregion

        #region Refresh Token Added to User

        user.RefreshToken = refreshToken;
        user.RefreshTokenExpiryTime = DateTime.Now.AddDays(Convert.ToInt32(_configuration["Jwt:RefreshTokenExpiration"]));
        await _userService.UpdateAsync(user);

        #endregion

        var tokenDto = new TokenInfo()
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            ExpireDate = token.ValidTo,
            RefreshToken = refreshToken
        };

        return Response<TokenInfo>.Success(tokenDto, 200);
    }

    private static bool ValidPassword(string password, User user)
    {
        return Helper.HashSha256(password) == user.PasswordHash;
    }

    public async Task<Response<TokenInfo>> RefreshToken(TokenApiModel tokenApiModel)
    {
        try
        {
            var principal =
                _tokenService.GetPrincipalFromExpiredToken(tokenApiModel.AccessToken ?? throw new InvalidOperationException());
            var username = principal.Identity?.Name;
            var user = await _userService.GetAsync(x => x.Email.Equals(username));
            if (user is null || user.RefreshToken != tokenApiModel.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return Response<TokenInfo>.Fail("Invalid client request", 400);

            var newAccessToken = _tokenService.CreateToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = newRefreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(Convert.ToInt32(_configuration["Jwt:RefreshTokenExpiration"]));
            await _userService.UpdateAsync(user);

            var tokenDto = new TokenInfo()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(newAccessToken),
                ExpireDate = newAccessToken.ValidTo,
                RefreshToken = newRefreshToken
            };

            return Response<TokenInfo>.Success(tokenDto, 200);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task Revoke(string email)
    {
        var user = await _userService.GetAsync(x => x.Email.Equals(email));
        if (user == null) return;

        user.RefreshToken = string.Empty;
        await _userService.UpdateAsync(user);
    }
}