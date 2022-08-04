using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class Categoria
{
    public Guid CategoriaId {get;set;}
    public string? Nombre {get;set;}
    public string? Descripcion {get;set;}
    public int Peso {get;set;}

    [JsonIgnore]
    public virtual ICollection<Tarea>? Tareas {get;set;}
}