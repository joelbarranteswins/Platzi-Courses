using Microsoft.EntityFrameworkCore;
using WebApp.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//agrergando la inyeccion de dependencias
builder.Services.AddDbContext<SchoolContext>(
    options => options.UseInMemoryDatabase(databaseName: "test")
    );
// builder.Services.AddSqlServer<SchoolContext>(
//     builder.Configuration.GetConnectionString("MyDataBase"));


var app = builder.Build();

//Accede a Schoolcontext y crea una base de datos en memoria
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<SchoolContext>();
        context.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        var logger = app.Services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred creating the DB.");
    }
}



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=School}/{action=Index}/{id?}");

app.Run();
