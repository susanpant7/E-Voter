using E_Voter.Api.Configuration;
using E_Voter.Application;
using E_Voter.Application.Security;
using E_Voter.Infrastructure;
using E_Voter.Infrastructure.Security;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
builder.Services.AddSingleton<ITokenValidator, TokenValidator>();



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