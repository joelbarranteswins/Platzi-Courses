using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proyectoef.Models;

public class Tarea 
{
    //[Key]
    public Guid TareaID { get; set; }
    //[Required]
    //[MaxLength(200)]
    public string? Titulo { get; set; }
    public string? Descripcion { get; set; }
    //[ForeignKey("Categoria")]
    public Guid CategoriaID { get; set; }
    public Prioridad PrioridadTarea { get; set; }
    public DateTime FechaCreacion { get; set; }
    public virtual Categoria? Categoria { get; set; }
    //[NotMapped]
    public string? Resumen { get; set; }
}

public enum Prioridad 
{
    Alta,
    Media,
    Baja
}