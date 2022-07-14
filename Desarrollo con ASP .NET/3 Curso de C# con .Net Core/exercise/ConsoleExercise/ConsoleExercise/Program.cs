// See https://aka.ms/new-console-template for more information
namespace CoreEscuela.Entidades;
using System;
using static System.Console;
using System.Collections.Generic;


class Program
{
    static public void Main(string[] strings)
    {
        
        var engine = new EscuelaEngine();
        engine.Inicialize();
        ImprimirCursosEscuela(engine.Escuela);

        WriteLine(Printer.Imprimir(len: 10, color: ConsoleColor.Green));

    }

    private static void ImprimirCursosEscuela(Escuela escuela)
    {
        //if (escuela != null && escuela.cursos != null)
        if (escuela?.cursos != null)
        {
            foreach (var cursos in escuela.cursos)
            {
                Console.WriteLine(cursos.Nombre + "," + cursos.UniqueId);
            }
        }
        
    }

}



