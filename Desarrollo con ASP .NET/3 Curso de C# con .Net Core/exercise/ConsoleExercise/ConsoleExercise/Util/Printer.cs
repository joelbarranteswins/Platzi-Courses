using static System.Console;
using System.Collections.Generic;


namespace CoreEscuela.Entidades;

public static class Printer
{
    // public static void Imprimir(string mensaje)
    // {
    //     WriteLine(mensaje);
    // }
    public static void Imprimir(int len = 10,ConsoleColor color=default(ConsoleColor))
    {
        if (color != default(ConsoleColor))
        {
            var linea = "".PadLeft(len, '=');
            ForegroundColor = color;
        }

        
        // ConsoleColor original = Console.ForegroundColor;
        // Console.ForegroundColor = color;
        // WriteLine(mensaje);
        // Console.ForegroundColor = original;
    }
}