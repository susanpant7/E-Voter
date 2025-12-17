using E_Voter.Api.Middlewares;

namespace E_Voter.Api.Configuration;

public static class MiddlewareConfig
{
    public static void UseCustomMiddlewares(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionHandlingMiddleware>();
        app.UseMiddleware<TokenValidationMiddleware>();
    }
}