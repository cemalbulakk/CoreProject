using Application.Services.Interfaces;
using Infrastructure.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {

        services.AddScoped<IRoleService, RoleService>();

        return services;
    }
}