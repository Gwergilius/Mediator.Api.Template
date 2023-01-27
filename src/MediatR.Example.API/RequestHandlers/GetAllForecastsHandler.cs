using MediatR.Example.API.Requests;
using MediatR.Example.API.Services;

namespace MediatR.Example.API.RequestHandlers;

public class GetAllForecastsHandler
    : IRequestHandler<GetAllForecatsRequest, IEnumerable<WeatherForecast>>
{
    private readonly IWeatherForecastService _forecastService;

    public GetAllForecastsHandler(IWeatherForecastService forecastService)
    {
        _forecastService = forecastService;
    }

    public async Task<IEnumerable<WeatherForecast>> Handle(
        GetAllForecatsRequest request,
        CancellationToken cancellationToken)
        => await _forecastService.GetWeatherForecast();
}
