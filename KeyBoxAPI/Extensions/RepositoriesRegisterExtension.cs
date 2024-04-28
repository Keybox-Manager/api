using KeyBoxAPI.Core.Interfaces.Repositories;
using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Repositories;

namespace KeyBoxAPI.Extensions;

internal static class RepositoriesRegisterExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepository<Account>, AccountRepository>();

        return services;
    }
}