using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public class Evaluacion
{
    public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
    public string Nombre { get; set; }
    public Alumno Alumno { get; set; }
    public Asignatura Asignatura { get; set; }
    public float Nota { get; set; }

    public Evaluacion() => UniqueId = Guid.NewGuid().ToString();

    public override string ToString()
    {
        return $"Nombre: \"{Nombre}\", Alumno: {Alumno.Nombre} {Environment.NewLine} Asignatura: {Asignatura.Nombre}, Nota: {Nota}";
    }
}

