namespace E_Voter.Application.AppSettings;

public class AppSetting
{
    public ConnectionStrings ConnectionStrings { get; set; } = new();
    public Logging Logging { get; set; } = new();
    public string AllowedHosts { get; set; } = "*";
    public string ClientUrl { get; set; } = "*";
    public string AuthServiceBaseUrl { get; set; } = "*";
    public string ClientCorsPolicy { get; set; } = "*";
    public AuthSetting AuthSetting { get; set; } = new();
}