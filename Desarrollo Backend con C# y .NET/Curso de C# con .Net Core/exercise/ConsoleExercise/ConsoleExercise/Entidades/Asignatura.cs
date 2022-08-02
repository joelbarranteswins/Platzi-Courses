using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public class Asignatura
{
    public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
    public string Nombre { get; set; }
    public List<Evaluacion> Evaluaciones;

    public Asignatura()
    {
        UniqueId = Guid.NewGuid().ToString();
        Evaluaciones = new List<Evaluacion>();
    }
}

