using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Contexts.Ef;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<RoleGroup> RoleGroups { get; set; }
    public DbSet<Role> Roles { get; set; }
}

