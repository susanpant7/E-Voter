using System.Text.Json;
using E_Voter.Api.Common;
using E_Voter.Api.Configuration;
using E_Voter.Api.utils;

namespace E_Voter.Api.Middlewares;

public class ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unhandled exception occurred.");

            await HandleExceptionAsync(context, ex);
        }
    }
    
    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var statusCode = ExceptionHelper.GetStatusCode(exception);
        var title = ExceptionHelper.GetUserFriendlyTitle(exception);
        var exceptionMessage = context.RequestServices
            .GetRequiredService<IWebHostEnvironment>()
            .IsDevelopment()
            ? exception.ToString() : exception.Message;
        // Construct standard ApiResponse format
        var response = ApiResponse<string>.ErrorResponse(
            title: title,
            status: (int)statusCode,
            errors: [exceptionMessage]
        );

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = statusCode;


        var json = JsonSerializer.Serialize(response, JsonConfig.DefaultOptions);

        await context.Response.WriteAsync(json);
    }
}
