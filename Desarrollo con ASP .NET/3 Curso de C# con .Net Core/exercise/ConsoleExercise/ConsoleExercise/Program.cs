// See https://aka.ms/new-console-template for more information
namespace CoreEscuela.Entidades;
using System;
using static System.Console;


class Program
{
    static public void Main(string[] strings)
    {
        Escuela escuela = new Escuela(
            nombre: "joel", año: 195, tipo: TiposEscuela.Secundaria, pais: "Perú");
        Console.WriteLine(escuela);
        Console.WriteLine(escuela.GetHashCode());
        Console.WriteLine(escuela.ToString());
        Console.WriteLine(escuela.Equals(escuela));

        Curso[] arregloCursos = {
            new Curso(){Nombre = "101"},
            new Curso(){Nombre = "201"}
        };

        escuela.cursos = arregloCursos;
 

        Curso curso3 = new Curso()
        {
            Nombre = "301",
        };

        

        Console.WriteLine($"{curso3.Nombre}, {curso3.UniqueId}");

        Console.WriteLine(curso3);

        Console.WriteLine("=====================");
        ImprimirCursosWhile(arregloCursos);
        Console.WriteLine("=====================");
        ImprimirCursosDoWhile(arregloCursos);
        Console.WriteLine("=====================");
        ImprimirCursosFor(arregloCursos);
        Console.WriteLine("=====================");
        ImprimirCursosForEach(arregloCursos);
        Console.WriteLine("=====================");
        if (escuela != null && escuela.cursos != null)
        {
            ImprimirCursosEscuela(escuela);
        }


        bool answer = 10 == 10;
        Console.WriteLine(!answer);
            
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

    private static void ImprimirCursosWhile(Curso[] arregloCursos)
    {
        int contador = 0;
        while (contador < arregloCursos.Length)
        {
            Console.WriteLine($"{arregloCursos[contador].Nombre}, {arregloCursos[contador].UniqueId}");
            contador++;
        }
    }

    private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
    {
        int contador = 0;
        do
        {
            Console.WriteLine($"{arregloCursos[contador].Nombre}, {arregloCursos[contador].UniqueId}");
            
        } while (++contador < arregloCursos.Length);
    }

    private static void ImprimirCursosFor(Curso[] arregloCursos)
    {
        for (int contador = 0; contador < arregloCursos.Length; contador++)
        {
            Console.WriteLine($"{arregloCursos[contador].Nombre}, {arregloCursos[contador].UniqueId}");

        } 
    }

    private static void ImprimirCursosForEach(Curso[] arregloCursos)
    {
        foreach (Curso curso in arregloCursos)
        {
            Console.WriteLine($"{curso.Nombre}, {curso.UniqueId}");

        }
    }

}



