namespace MediatR.Example.API.Services;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecast>> GetWeatherForecast();
}