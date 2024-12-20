using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Infrastructure.Data;

namespace ProductManagement.Infrastructure.DependencyInjection;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var conString = configuration.GetConnectionString("productManagementCS");        
        services.AddDbContext<ProductDbContext>(options => options.UseSqlite(conString));

        return services;
    }
}
