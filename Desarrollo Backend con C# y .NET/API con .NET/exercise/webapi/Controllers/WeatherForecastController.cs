using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        if (ListWeatherForecast?.Count == 0)
        {
            ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToList();
        }
    }

    [HttpGet(Name = "GetWeatherForecast")]
    //[Route("Get/weatherforecast")]
    //[Route("Get/weatherforecast2")]
    //[Route("[action]")] //permite utilizar el nombre para su llamado del api
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogDebug("Retornando el listado de WeatherForecast");
       return ListWeatherForecast;
    }

    [HttpPost]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        ListWeatherForecast.Add(weatherForecast);
        return Ok();
    }

    [HttpDelete("{index}")]
    public IActionResult Delete(int index)
    {
        if (index < 0 || index >= ListWeatherForecast.Count)
        {
            return BadRequest("The given ID is out of bounds.");
        }
        ListWeatherForecast.RemoveAt(index);
        return Ok();
    }

    [HttpPut]
    public IActionResult Put(int index, WeatherForecast weatherForecast)
    {
        ListWeatherForecast[index] = weatherForecast;
        return Ok();
    }

    [HttpPatch]
    public IActionResult Patch(int index, WeatherForecast weatherForecast)
    {
        ListWeatherForecast[index] = weatherForecast;
        return Ok();
    }
}
