using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class ProductService : EfRepositoryBase<Product, AppDbContext>, IProductService
{
    public ProductService(AppDbContext context) : base(context)
    {
    }
}