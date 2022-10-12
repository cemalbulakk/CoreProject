using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IRoleGroupService : IAsyncRepository<RoleGroup>, IRepository<RoleGroup>
{
    
}