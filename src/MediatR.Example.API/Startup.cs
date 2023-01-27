using MediatR.Example.API.Services;

namespace MediatR.Example.API;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Add services to the container.
    /// </summary>
    /// <param name="services">DI service container</param>
    public void ConfigureServices(IServiceCollection services)
	{
        services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
    }

    /// <summary>
    /// Configure the HTTP request pipeline. 
    /// </summary>
    /// <param name="app"></param>
    /// <param name="environment"></param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment environment)
	{
        if (environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}
