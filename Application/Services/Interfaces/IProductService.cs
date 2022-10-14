using Domain.Entities;
using Persistence.Repositories;

namespace Application.Services.Interfaces;

public interface IProductService : IAsyncRepository<Product>, IRepository<Product>
{

}