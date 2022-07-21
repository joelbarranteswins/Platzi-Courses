namespace proyectoef.Models;

public class Tarea 
{
    public Guid TareaID { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public Guid CategoriaID { get; set; }
    public Prioridad PrioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
    public Categoria Categoria { get; set; }
}

public enum Prioridad 
{
    Alta,
    Media,
    Baja
}