using KeyBoxAPI.Application.Services;
using KeyBoxAPI.Core.Interfaces.Services;
using KeyBoxAPI.Core.Models;

namespace KeyBoxAPI.Extensions;

internal static class ServicesRegisterExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IService<Account>, AccountService>();

        return services;
    }
}