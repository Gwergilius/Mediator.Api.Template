namespace MediatR.Example.API.Requests;

public class GetForecastRequest: IRequest<WeatherForecast>
{
    public GetForecastRequest(string date)
    {
        if(DateOnly.TryParse(date, out var dateValue))
        {
            Date = dateValue;
        }
        else
        {
            throw new FormatException($"'{date}': Not a valid date");
        }
    }

    public DateOnly Date { get; }
}
