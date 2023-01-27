namespace MediatR.Example.API.Requests;

public record GetAllForecatsRequest : IRequest<IEnumerable<WeatherForecast>>
{
}
