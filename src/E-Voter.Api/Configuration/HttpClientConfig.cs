using E_Voter.Application.AppSettings;
using E_Voter.Application.Security;
using E_Voter.Infrastructure.Security;

namespace E_Voter.Api.Configuration;

public static class HttpClientConfig
{
    public static void RegisterHttpClients(this IServiceCollection services, AppSetting appSettings)
    {
        services.AddHttpClient<IAuthClientService, AuthClientService>(client =>
        {
            var authServiceUrl = appSettings.AuthServiceBaseUrl
                                 ?? throw new InvalidOperationException("AuthService:BaseUrl not configured");
            client.BaseAddress = new Uri(authServiceUrl);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        });
    }
}