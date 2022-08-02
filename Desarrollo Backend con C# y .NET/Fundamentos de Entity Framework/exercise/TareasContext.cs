using Microsoft.EntityFrameworkCore;
using proyectoef.Models;

namespace proyectoef;

public class TareasContext: DbContext
{
    public DbSet<Categoria>? Categorias {get;set;}
    public DbSet<Tarea>? Tareas {get;set;}

    public TareasContext(DbContextOptions<TareasContext> options) :base(options) { }
    /* Creating Fluint API, tiene mayor prioridad a los atributos de la clase Categoria */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = new List<Categoria>();
        categorias.Add(new Categoria 
        { 
            CategoriaId = Guid.Parse("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ac"), 
            Nombre = "Actividades pendientes", 
            Peso = 20
        });
        categorias.Add(new Categoria 
        { 
            CategoriaId = Guid.Parse("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ae"), 
            Nombre = "Actividades personales",
            Peso = 50
        });

        //Fluent API que sirve para establecer las propiedades de las entidades
        modelBuilder.Entity<Categoria>(
            categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(c => c.CategoriaId);
                categoria.Property(c => c.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(c => c.Descripcion).IsRequired(false);
                categoria.Property(c => c.Peso);
                categoria.HasData(categorias);

            });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { 
            TareaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb410"), 
            CategoriaId = Guid.Parse("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ac"),
            PrioridadTarea = Prioridad.Media, 
            Titulo = "Pago de servicios publicos", 
            FechaCreacion = DateTime.Now
            });
        tareasInit.Add(new Tarea() 
        { 
            TareaId = Guid.Parse("fe2de405-c38e-4c90-ac52-da0540dfb411"), 
            CategoriaId = Guid.Parse("e2c610a2-ce8e-4ad7-ab9c-7a408c8b61ae"),
            PrioridadTarea = Prioridad.Baja, 
            Titulo = "Terminar de ver pelicula en netflix", 
            FechaCreacion = DateTime.Now
            });
        
        //Fluent API que sirve para establecer las propiedades de las entidades
        modelBuilder.Entity<Tarea>(
            tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(t => t.TareaId);
                tarea.HasOne(t => t.Categoria).WithMany(t => t.Tareas).HasForeignKey(t => t.CategoriaId);
                tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200);
                tarea.Property(t => t.Descripcion).IsRequired(false);
                tarea.Property(t => t.FechaCreacion).HasDefaultValueSql("GETDATE()");
                tarea.Property(t => t.PrioridadTarea);
                tarea.Ignore(t => t.Resumen);
                tarea.Ignore(t => t.Estado);
                tarea.HasData(tareasInit);
            });
    }
}
