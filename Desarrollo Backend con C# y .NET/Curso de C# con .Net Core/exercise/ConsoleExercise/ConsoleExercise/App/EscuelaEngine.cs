using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades;

public class EscuelaEngine
{
    public Escuela? Escuela { get; set; }
    public EscuelaEngine()
    {
    }

    public void Inicialize()
    {
        Escuela = new Escuela(
            nombre: "Academy", año: 195, tipo: TiposEscuela.Secundaria, pais: "Perú");


        CargarCursos();
        CargarAsignaturas();
        foreach (var curso in Escuela.cursos)
        {
            curso.Alumnos = GenerarAlumnosAlAzar(cantidad: 35);
        }
        CargarEvaluaciones();
    }

    private void CargarEvaluaciones()
    {
        
        foreach (var curso in Escuela.cursos)
        {
            foreach (var asignatura in curso.Asignaturas)
            {
                foreach (var alumno in curso.Alumnos)
                {
                
                
                    double grade1 = GetRandomNumber(0.0, 5.0);
                    double grade2 = GetRandomNumber(0.0, 5.0);
                    double grade3 = GetRandomNumber(0.0, 5.0);
                    double grade4 = GetRandomNumber(0.0, 5.0);
                    double grade5 = GetRandomNumber(0.0, 5.0);

                    asignatura.Evaluaciones.Add(
                        new Evaluacion() { Nombre = $"Examen 1", Alumno = alumno, Asignatura = asignatura, Nota = (float)grade1 }
                        );
                    asignatura.Evaluaciones.Add(
                        new Evaluacion() { Nombre = $"Examen 2", Alumno = alumno, Asignatura = asignatura, Nota = (float)grade2 }
                        );
                    asignatura.Evaluaciones.Add(
                        new Evaluacion() { Nombre = $"Examen 3", Alumno = alumno, Asignatura = asignatura, Nota = (float)grade3 }
                        );
                    asignatura.Evaluaciones.Add(
                        new Evaluacion() { Nombre = $"Examen 4", Alumno = alumno, Asignatura = asignatura, Nota = (float)grade4 }
                        );
                    asignatura.Evaluaciones.Add(
                        new Evaluacion() { Nombre = $"Examen 5", Alumno = alumno, Asignatura = asignatura, Nota = (float)grade5 }
                        );

                }
            }
        }
    }



    public static double GetRandomNumber(double minimum, double maximum)
    {
        Random random = new Random();
        return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 1);
    }

    private void CargarAsignaturas()
    {
        foreach (var curso in Escuela.cursos)
        {
            var listaAsignaturas = new List<Asignatura>()
                {   
                            new Asignatura{Nombre="Matemáticas"} ,
                            new Asignatura{Nombre="Educación Física"},
                            new Asignatura{Nombre="Castellano"},
                            new Asignatura{Nombre="Ciencias Naturales"}
                };
            curso.Asignaturas = listaAsignaturas;
            
        }
    }

    private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
    {
        string[] nombres1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
        string[] nombres2 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
        string[] apellidos = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

        var listaAlumnos = from n1 in nombres1
                           from n2 in nombres2
                           from a1 in apellidos
                           select new Alumno { Nombre = $"{n1} {n2} {a1}" };

        return listaAlumnos.OrderBy((alumno) => alumno.UniqueId).Take(cantidad).ToList();
    }

    private void CargarCursos()
    {
        Escuela.cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde},
            };

        Random rnd = new Random();
        foreach (var curso in Escuela.cursos)
        {
            int cantRandom = rnd.Next(5, 20);
            curso.Alumnos = GenerarAlumnosAlAzar(cantRandom);
        }
    }
}


