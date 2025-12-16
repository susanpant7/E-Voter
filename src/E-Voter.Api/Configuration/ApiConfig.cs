using E_Voter.Api.AppSettings;
using E_Voter.Api.Middlewares;
using E_Voter.Api.Security;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace E_Voter.Api.Configuration;

public static class ApiConfig
{
    public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = services.AddAppSettings(configuration);
        services.AddHttpContextAccessor();
        services.AddAuth(appSettings);
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

        // 1. Exception Handling (FIRST - catches all errors)
        app.UseMiddleware<ExceptionHandlingMiddleware>();

        // 2. HTTPS Redirection (redirects HTTP to HTTPS)
        //app.UseHttpsRedirection();

        // 3. CORS (before authentication - allows cross-origin requests)
        app.UseCors(appSettings.ClientCorsPolicy);

        app.UseMiddleware<TokenRefreshMiddleware>();
        
        // 4. Authentication (who are you?)
        app.UseAuthentication();

        // 5. Authorization (what can you do?)
        app.UseAuthorization();

        // 6. Custom Middlewares (business logic, logging, etc.)
        app.UseCustomMiddlewares();

        // 7. Map Endpoints (LAST - routes to controllers)
        app.MapControllers();

        //app.MapHealthChecks("/health");

        return app;
    }

    private static void AddCorsPolicy(this IServiceCollection services, AppSetting appSettings)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(appSettings.ClientCorsPolicy, policy =>
            {
                policy
                    .WithOrigins(appSettings.ClientUrl) // React dev server
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials(); // if you need cookies/auth headers
            });
        });

    }

    private static IApplicationBuilder UseCustomMiddlewares(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionHandlingMiddleware>();
    }
}
