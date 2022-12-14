using Logic.Services;
using Logic.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Logic;

public static class ForStartup
{
    public static IServiceCollection AddLogicServices(this IServiceCollection services)
    {
        services
            .AddTransient<IAuthService, AuthService>()
            .TryAddScoped<HttpClient>();

        return services;
    }
}