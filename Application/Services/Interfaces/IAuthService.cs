using Application.Features.Dtos.Auth;
using Common.Dtos;
using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IAuthService
{
    Task<Response<Boolean>> Register(RegisterDto model);
    Task<Response<TokenInfo>> Auth(AuthDto authDto);
    Task<Response<Boolean>> Logout(ApplicationUser user);
}