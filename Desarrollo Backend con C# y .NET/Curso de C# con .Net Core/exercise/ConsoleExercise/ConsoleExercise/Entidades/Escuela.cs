using System;


namespace CoreEscuela.Entidades;

public class Escuela
{
    public string Nombre { get; set; }
    public int AñoDeCreación { get; set; }
    public string Pais { get; set; }
    public string Ciudad { get; set; }
    public TiposEscuela TipoEscuela { get; set; }
    public List<Curso> cursos { get; set; }

    public Escuela(string nombre, int año)
    {
        (this.Nombre, this.AñoDeCreación) = (nombre, año);
    }

    public Escuela(
        string nombre, int año, TiposEscuela tipo, 
        string pais = "", string ciudad = "")
    {
        (Nombre, AñoDeCreación) = (nombre, año);
        Pais = pais;
        Ciudad = ciudad;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override string ToString()
    {
        return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
    }
}

