using E_Voter.Application.ElectionParties;
using E_Voter.Application.MediaFiles;
using E_Voter.Application.Voter;
using Microsoft.Extensions.DependencyInjection;

namespace E_Voter.Application;

public static class ApplicationConfig
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Services
        services.AddScoped<IVoterService, VoterService>();
        services.AddScoped<IElectionPartyService, ElectionPartyService>();
        services.AddScoped<IMediaFileService, MediaFileService>();

        return services;
    }
}