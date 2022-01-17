using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var environmentName = builder.Environment.EnvironmentName;

builder.Configuration.AddAppConfig("TestApp", environmentName, "ConfigurationProfile", false);

builder.Services.Configure<MyOptions>(builder.Configuration.GetRequiredSection("MyKey"));

var app = builder.Build();

app.MapGet("/configuration", (IOptions<MyOptions> options) => options.Value);

app.Run();