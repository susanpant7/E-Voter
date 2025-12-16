using E_Voter.Application.Voter;
using Microsoft.Extensions.DependencyInjection;

namespace E_Voter.Application;

public static class ApplicationConfig
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IVoterService, VoterService>();

        return services;
    }
}