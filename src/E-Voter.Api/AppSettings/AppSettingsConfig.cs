namespace E_Voter.Api.AppSettings;

public static class AppSettingsConfig
{
    public static AppSetting AddAppSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettings = new AppSetting();
        configuration.Bind(appSettings);

        // Make it injectable via DI
        services.AddSingleton(appSettings);

        return appSettings;
    }
}