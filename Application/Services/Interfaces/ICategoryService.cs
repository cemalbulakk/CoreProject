using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface ICategoryService : IAsyncRepository<Category>, IRepository<Category>
{

}