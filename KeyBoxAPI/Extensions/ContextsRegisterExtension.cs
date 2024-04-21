using Microsoft.EntityFrameworkCore;

namespace KeyBoxAPI.Extensions;

internal static class ContextsRegisterExtension
{
    public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
    {
        //var connectionString = configuration.GetConnectionString(nameof(OnlineStoreBycleDbContext));
        //services.AddDbContext<OnlineStoreBycleDbContext>(x => x.UseNpgsql(connectionString), ServiceLifetime.Transient);

        return services;
    }
}
