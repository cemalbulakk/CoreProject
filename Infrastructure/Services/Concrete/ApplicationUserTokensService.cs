using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class ApplicationUserTokensService : EfRepositoryBase<ApplicationUserTokens, AppDbContext>, IApplicationUserTokensService
{
    public ApplicationUserTokensService(AppDbContext context) : base(context)
    {
    }
}