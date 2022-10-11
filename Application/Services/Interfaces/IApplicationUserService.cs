using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IApplicationUserService : IAsyncRepository<ApplicationUser>, IRepository<ApplicationUser>
{

}