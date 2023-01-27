using MediatR.Example.API.Requests;
using MediatR.Example.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Example.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger _logger;

    public WeatherForecastController(
        IMediator mediator,
        ILogger<WeatherForecastController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<WeatherForecast>> Get()
    {
        return await _mediator.Send(new GetAllForecatsRequest());
    }
}
