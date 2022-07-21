using static System.Console;
using System.Collections.Generic;


namespace CoreEscuela.Entidades;

public static class Printer
{
    public static void WriteLine(string mensaje, ConsoleColor color = default(ConsoleColor))
    {
        Imprimir(len: mensaje.Length, color: color);
        Console.WriteLine(mensaje);
        Imprimir(len: mensaje.Length, color: color);
    }
    public static void Imprimir(int len = 10, ConsoleColor color=default(ConsoleColor))
    {
        if (color != default(ConsoleColor))
        {
            ConsoleColor original = Console.ForegroundColor;
            var linea = "".PadLeft(len, '=');
            ForegroundColor = color;
            Console.WriteLine(linea);
            Console.ForegroundColor = original;
        } 
    }
}