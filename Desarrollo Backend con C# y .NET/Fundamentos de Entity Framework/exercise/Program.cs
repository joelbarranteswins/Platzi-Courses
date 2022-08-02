
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectoef;
using proyectoef.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TareasContext>(p =>p.UseInMemoryDatabase("TareasDB"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", ([FromServices] TareasContext dbContext) => 
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapGet(
    "/api/tareas", 
    ([FromServices] TareasContext dbContext) =>
{
    var tareas = dbContext.Tareas;
    return Results.Ok(tareas?.Include(t=>t.Categoria));
    //tareas.Where(t=>t.PrioridadTarea == proyectoef.Models.Prioridad.Media
    
});


app.MapGet(
    "/api/categorias", 
    ([FromServices] TareasContext dbContext) =>
{
    var categorias = dbContext.Categorias;
    return Results.Ok(categorias?.Where(c=>c.Nombre == "Actividades pendientes"));
});


app.MapPost(
    "/api/tareas", 
    async ([FromServices] TareasContext dbContext, 
    [FromBody] Tarea tarea) =>
{
    tarea.TareaId = Guid.NewGuid();
    tarea.FechaCreacion = DateTime.Now;
    await dbContext.AddAsync(tarea);
    //await dbContext.Tareas.AddAsync(tarea);

    await dbContext.SaveChangesAsync();

    return Results.Ok();
});

app.MapPut(
    "/api/tareas/{id}", 
    async ([FromServices] TareasContext dbContext, 
    [FromBody] Tarea tarea,
    [FromRoute] Guid id) =>
{
    var tareaActual = dbContext?.Tareas?.Find(id);
    if (tareaActual != null)
    {
        tareaActual.CategoriaId = tarea.CategoriaId;
        tareaActual.Titulo = tarea.Titulo;
        tareaActual.PrioridadTarea = tarea.PrioridadTarea;
        tareaActual.Descripcion = tarea.Descripcion;
        
        await dbContext.SaveChangesAsync();

        return Results.Ok();
    }

    return Results.NotFound();
});

app.MapDelete(
    "/api/tareas/{id}", 
    async ([FromServices] TareasContext dbContext, 
    [FromRoute] Guid id) =>
{
    var tareaActual = dbContext?.Tareas?.Find(id);

    if(tareaActual == null)
    {
        return Results.NotFound("Task not found.");
    }
        
    dbContext?.Tareas?.Remove(tareaActual);
    await dbContext.SaveChangesAsync();

    return Results.Ok();
});


app.Run();
