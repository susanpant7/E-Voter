using E_Voter.Api.Configuration;
using E_Voter.Application;
using E_Voter.Application.Security;
using E_Voter.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

builder.Services.AddHttpClient<IAuthServiceClient, AuthServiceClient>(client =>
{
    var authServiceUrl = builder.Configuration["AuthService:BaseUrl"] 
                         ?? throw new InvalidOperationException("AuthService:BaseUrl not configured");
    client.BaseAddress = new Uri(authServiceUrl);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

services.AddApiConfiguration(configuration);
services.AddApplication();
services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.Run();