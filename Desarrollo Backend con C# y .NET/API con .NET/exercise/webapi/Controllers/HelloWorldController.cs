using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;

    private readonly ILogger<HelloWorldController> _logger;
    public HelloWorldController(
        ILogger<HelloWorldController> logger, IHelloWorldService helloWorldService)
    {
        _logger = logger;
        this.helloWorldService = helloWorldService;
    }

    // public HelloWorldController(IHelloWorldService helloWorldService)
    // {
    //     this.helloWorldService = helloWorldService;
    // }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogDebug("Retornando un string");
        _logger.LogInformation("Retornando un string");
        _logger.LogWarning("Retornando un string");
        _logger.LogError("Retornando un string");
        _logger.LogCritical("Retornando un string");
        
        return Ok(helloWorldService.GetHelloWorld());
    }
}