using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IApplicationUserTokensService : IAsyncRepository<ApplicationUserTokens>, IRepository<ApplicationUserTokens>
{
    
}