// See https://aka.ms/new-console-template for more information
namespace CoreEscuela.Entidades;
using System;
using static System.Console;
using System.Collections.Generic;


class Program
{
    static public void Main(string[] strings)
    {
        Printer.WriteLine(mensaje: "Colegio 4500", color: ConsoleColor.Magenta);

        var engine = new EscuelaEngine();
        engine.Inicialize();
        ImprimirCursosEscuela(engine.Escuela);
        ImprimirCursosEvaluaciones(engine.Escuela);

        
    }

    

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        if (escuela?.cursos != null)
        {
            Console.WriteLine("----------------------------------------------------");
            foreach (var curso in escuela.cursos)
            {
                Console.WriteLine(curso.Nombre + "," + curso.UniqueId);
            }
        }
    }

    private static void ImprimirCursosEvaluaciones(Escuela escuela)
    {
        if (escuela?.cursos != null)
        {
            Console.WriteLine("----------------------------------------------------");
            foreach (var curso in escuela.cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var evaluacion in asignatura.Evaluaciones)
                    {
                        Console.WriteLine(evaluacion.ToString());
                    }
                }
            }
        }
    }

}



