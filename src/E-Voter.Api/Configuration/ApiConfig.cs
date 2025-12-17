using E_Voter.Api.Middlewares;
using E_Voter.Api.Security;
using E_Voter.Application.AppSettings;
using E_Voter.Application.Security;
using E_Voter.Infrastructure.Security;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace E_Voter.Api.Configuration;

public static class ApiConfig
{
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = services.AddAppSettings(configuration);

        services.AddScoped<ILoginService, LoginService>();
        services.AddHttpContextAccessor();
        services.AddAuth(appSettings);
        services.RegisterHttpClients(appSettings);
        // Global Authorization Filter (all controllers require [Authorize])
        services.AddControllers(options =>
        {
            options.Filters.Add(new AuthorizeFilter());
        });
        services.AddCorsPolicy(appSettings);

        return services;
    }

    public static IApplicationBuilder UseApiConfiguration(this WebApplication app)
    {
        var appSettings = app.Services.GetRequiredService<AppSetting>();

        app.UseCustomMiddlewares();

        //app.UseHttpsRedirection();

        app.UseCors(appSettings.ClientCorsPolicy);

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        //app.MapHealthChecks("/health");

        return app;
    }
    
}
