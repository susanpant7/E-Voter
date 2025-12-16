namespace E_Voter.Api.utils;

public static class ExceptionHelper
{
    public static int GetStatusCode(Exception? exception)
    {
        return exception switch
        {
            ArgumentNullException => StatusCodes.Status400BadRequest,
            ArgumentException => StatusCodes.Status400BadRequest,
            InvalidOperationException => StatusCodes.Status400BadRequest,
            KeyNotFoundException => StatusCodes.Status404NotFound,
            UnauthorizedAccessException => StatusCodes.Status401Unauthorized,
            NotImplementedException => StatusCodes.Status501NotImplemented,
            TimeoutException => StatusCodes.Status408RequestTimeout,
            NotSupportedException => StatusCodes.Status405MethodNotAllowed,
            BadHttpRequestException badRequestEx => badRequestEx.StatusCode,
            _ => StatusCodes.Status500InternalServerError
        };
    }

    public static string GetUserFriendlyTitle(Exception exception)
    {
        return exception switch
        {
            ArgumentNullException => "A required value was not provided.",
            ArgumentException => exception.Message,
            InvalidOperationException => exception.Message,
            KeyNotFoundException => "The requested resource was not found.",
            UnauthorizedAccessException => "You are not authorized to access this resource.",
            NotImplementedException => "This feature is not yet implemented.",
            TimeoutException => "The request took too long to process.",
            _ => "An unexpected error occurred. Please try again later."
        };
    }
}