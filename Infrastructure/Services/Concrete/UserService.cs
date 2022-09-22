using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class UserService : EfRepositoryBase<User, AppDbContext>, IUserService
{
    public UserService(AppDbContext context) : base(context)
    {
    }
}