using Application.Services.Interfaces;
using Domain.Contexts.Ef;
using Domain.Entities;
using Persistence.Repositories;

namespace Infrastructure.Services.Concrete;

public class CategoryService : EfRepositoryBase<Category, AppDbContext>, ICategoryService
{
    public CategoryService(AppDbContext context) : base(context)
    {
    }
}