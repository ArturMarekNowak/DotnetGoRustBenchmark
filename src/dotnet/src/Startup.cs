using App.Models;
using App.Repositories;
using App.Services;
using Microsoft.OpenApi.Models;

namespace App;

public class Startup
{
    private readonly IWebHostEnvironment _environment;

    public Startup(IConfiguration configuration, IWebHostEnvironment environment)
    {
        _configuration = configuration;
        _environment = environment;
    }

    private IConfiguration _configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo {Title = "App", Version = "v1"});
        });

        services.AddScoped<UsersService>();
        services.AddScoped<UsersRepository>();
        services.Configure<DatabasesConfiguration>(_configuration.GetSection("Databases"));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "gRPCGraphQLWebSockets v1"); });

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        app.UseCors(); 
    }
}
