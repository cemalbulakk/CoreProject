using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IUserService : IAsyncRepository<User>, IRepository<User>
{
    
}