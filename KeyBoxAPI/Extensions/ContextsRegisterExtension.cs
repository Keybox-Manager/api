using KeyBoxAPI.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace KeyBoxAPI.Extensions;

internal static class ContextsRegisterExtension
{
    public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString(nameof(KeyBoxDbContext));
        services.AddDbContext<KeyBoxDbContext>(x => x.UseNpgsql(connectionString), ServiceLifetime.Transient);

        return services;
    }
}
