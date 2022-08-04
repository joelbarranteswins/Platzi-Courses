using Microsoft.AspNetCore.Mvc;
using webapi.Models;
using webapi.Services;

namespace webapi.Controllers;

[Route("api/[controller]")]
public class TareaController : ControllerBase
{
    ITareasService? tareasService;

    TareasContext? dbcontext;
    
    
    public TareaController(ITareasService service, TareasContext context)
    {
        this.tareasService = service;
        this.dbcontext = context;
    }

    [HttpGet]
    [Route("createdb")]
    public IActionResult CreateDB()
    {
        dbcontext.Database.EnsureCreated();
        return Ok();
    }
    
    [HttpGet]
    public IActionResult Get()
    {   
        return Ok(tareasService?.Get());
    }

    [HttpPost]
    public IActionResult Post([FromBody] Tarea tarea)
    {
        tareasService?.Save(tarea);
        return Ok();
    }

    [HttpPut]
    public IActionResult Put(Guid id, [FromBody] Tarea tarea)
    {
        tareasService?.Update(id, tarea);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        tareasService?.Delete(id);
        return Ok();
    }


}
