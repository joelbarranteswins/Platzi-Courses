namespace proyectoef.Models;

public class Categoria
{
    public Guid CategoriaID { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public Version ICollection<Tarea> Tareas { get; set; }
}