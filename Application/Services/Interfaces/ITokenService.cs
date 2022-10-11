using Domain.Entities;

namespace Application.Services.Interfaces;

public interface ITokenService
{
    public Task<ApplicationUserTokens?> GetToken(ApplicationUser applicationUser);
    public Task<bool> DeleteToken(ApplicationUser applicationUser);
}