using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var environmentName = builder.Environment.EnvironmentName;

builder.Configuration.AddAppConfig("TestApp", environmentName, "ConfigurationProfile", false);

builder.Services.Configure<MyOptions>(builder.Configuration.GetRequiredSection("MyKey"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/configuration", (IOptions<MyOptions> options) => options.Value);

app.Run();

public class MyOptions
{
    public string SomeStringOption { get; set; }
    public bool BooleanOption { get; set;}
    public int IntegerOption { get; set; }
}