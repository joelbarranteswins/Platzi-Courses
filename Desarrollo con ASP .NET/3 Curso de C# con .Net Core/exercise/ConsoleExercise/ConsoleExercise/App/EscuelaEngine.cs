using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public class EscuelaEngine
{
    public Escuela Escuela { get; set; }
    public EscuelaEngine()
    {
        
    }

    public void Inicialize()
    {
        Escuela = new Escuela(
            nombre: "Academy", año: 195, tipo: TiposEscuela.Secundaria, pais: "Perú");

        Escuela.cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Mañana },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                        new Curso(){ Nombre = "401", Jornada = TiposJornada.Tarde },
                        new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde},
            };



    }

}

