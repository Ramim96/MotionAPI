using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Infrastructure.DependencyInjection;

public static class ApplicationCoreConfig
{
    public static IServiceCollection AddAppCoreConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSerilog((services, loggerConfig) => loggerConfig
            .ReadFrom.Configuration(configuration)
            .ReadFrom.Services(services)
            .Enrich.FromLogContext());

        services.AddDbContext<AppDbContextRead>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ReadDefaultConnection")));

        services.AddDbContext<AppDbContextWrite>(options =>
            options.UseSqlServer(configuration.GetConnectionString("WriteDefaultConnection")));

        return services;
    }
}