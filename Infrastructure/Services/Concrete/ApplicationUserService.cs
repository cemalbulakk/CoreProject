using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class ApplicationUserService : EfRepositoryBase<ApplicationUser, AppDbContext>, IApplicationUserService
{
    public ApplicationUserService(AppDbContext context) : base(context)
    {
    }
}