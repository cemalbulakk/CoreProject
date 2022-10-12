using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class RoleGroupService : EfRepositoryBase<RoleGroup, AppDbContext>, IRoleGroupService
{
    public RoleGroupService(AppDbContext context) : base(context)
    {
    }
}