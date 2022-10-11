using System.Security.Claims;
using Application.Features.Dtos.Auth;
using Application.Services.Interfaces;
using Common.Dtos;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services.Concrete;

public class AuthService : IAuthService
{
    private readonly ITokenService _tokenService;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<ApplicationRole> _roleManager;
    public AuthService(UserManager<ApplicationUser> userManager, ITokenService tokenService, SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
        _roleManager = roleManager;
    }

    public async Task<Response<Boolean>> Register(RegisterDto model)
    {
        try
        {
            var existUser = await _userManager.FindByEmailAsync(model.Email);
            if (existUser != null) return Response<Boolean>.Fail("User is exist.", 400);

            var user = new ApplicationUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName.Trim(),
                Email = model.Email.Trim(),
                UserName = model.Email.Trim()
            };

            var identityResult = await _userManager.CreateAsync(user, model.Password.Trim());
            return !identityResult.Succeeded
                ? Response<Boolean>.Fail(identityResult.Errors.Select(x => x.Description).ToList(), 400)
                : Response<Boolean>.Success(true, 200);
        }
        catch (Exception e)
        {
            return Response<Boolean>.Fail(e.Message, 400);
        }
    }

    public async Task<Response<TokenInfo>> Auth(AuthDto authDto)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(authDto.Email);
            if (user == null) return Response<TokenInfo>.Fail("Username or password is wrong", 400);

            SignInResult signInResult = await _signInManager.PasswordSignInAsync(user, authDto.Password, false, false);

            //Kullanıcı adı ve şifre kontrolü
            if (signInResult.Succeeded == false)
                return Response<TokenInfo>.Fail("Username or password is wrong", 400);

            var userTokens = await _tokenService.GetToken(user);
            if (userTokens is null)
                return Response<TokenInfo>.Fail("Username or password is wrong", 400);

            return Response<TokenInfo>.Success(new TokenInfo() { ExpireDate = userTokens.ExpireDate, Token = userTokens.Value }, 200);
        }
        catch (Exception e)
        {
            return Response<TokenInfo>.Fail(e.Message, 400);
        }

    }

    public async Task<Response<bool>> Logout(ApplicationUser user)
    {
        try
        {
            var response = await _tokenService.DeleteToken(user)
                ? Response<bool>.Success(true, 200)
                : Response<bool>.Fail("Not logout", 400);

            return response;
        }
        catch (Exception e)
        {
            return Response<bool>.Fail(e.Message, 500);
        }
    }
}