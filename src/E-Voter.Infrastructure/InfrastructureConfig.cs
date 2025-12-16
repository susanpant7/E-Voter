using E_Voter.Domain;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using E_Voter.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Voter.Infrastructure;

public static class InfrastructureConfig
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Register DbContext
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        services.AddScoped<AuditInterceptor>();
        
        // Register Repositories
        services.AddScoped<IVoterRepository, VoterRepository>();

        // Register UnitOfWork
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}