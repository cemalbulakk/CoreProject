using Application.Features.Dtos.Auth;
using Common.Dtos;

namespace Application.Services.Interfaces;

public interface IAuthService
{
    public Task<Response<TokenInfo>> Auth(AuthDto authDto);
    Task<Response<TokenInfo>> RefreshToken(TokenApiModel tokenApiModel);
    Task Revoke(string email);
}