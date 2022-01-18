using System;

namespace MetodosString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string ClassTopic = "Metodos de string";
            string school = "Casa";
            Console.WriteLine($"Estoy aprendiendo de {ClassTopic} en {school}. ");

            //Clone
            string SchoolClone = school.Clone().ToString();
            Console.WriteLine(SchoolClone);

            //CompareTo
            // si los valores son iguales devuelve 0
            // si son diferentes ls valores se retorna 1

            Console.WriteLine(ClassTopic.CompareTo(school));
            Console.WriteLine(school.CompareTo(ClassTopic));

            //Contains()
            //devuelve un True si contiene la palabra o letra
            Console.WriteLine(school.Contains("Ca"));

            //Endwith()
            //palabra o letra con la que finaliza
            Console.WriteLine(school.EndsWith("sa"));

            //StratsWith()
            Console.WriteLine(school.StartsWith("Ca"));

            //Equals()
            //retorna True o False dependiendo si es igual o no
            Console.WriteLine(school.Equals(SchoolClone));

            //IndexOf()
            //Regresa la posición dentro del string del carácter indicado en el argumento
            //los valores comienza desde 0
            Console.WriteLine(school.IndexOf("s"));

            //ToLower and ToUpper()
            Console.WriteLine(ClassTopic.ToLower());
            Console.WriteLine(ClassTopic.ToUpper());

            //Insert()
            //inserta un string en una posicion especificada
            Console.WriteLine(school.Insert(4, " es la mejor educcion "));

            //LastIndexOf()
            //Regresa la posición de la última vez que aparece el carácter
            Console.WriteLine(school.LastIndexOf("a"));

            //Remove()
            //Elimina los caracteres del string a partir de la posición que le indiquemos hasta el final
            Console.WriteLine(ClassTopic.Remove(6));

            //Replace()
            //Reemplaza todos los caracteres por otro indicado
            Console.WriteLine(ClassTopic.Replace("s", "z"));

            //split()
            //separa en trozos de acuerdo al valor especificado
            string[] split = ClassTopic.Split(new char[] { 's' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            //substring()
            //Devuelve un substring o trozo de string de acuerdo a las posiciones indicadas en los argumentos.
            Console.WriteLine(ClassTopic.Substring(2, 10));

            //ToCharArray()
            //Convierte el string en un arreglo de caracteres.
            school.ToCharArray();

            //Trim()
            string TextWithSpaces = " hola, habia espacios al principio y al final ";
            Console.WriteLine(TextWithSpaces.Trim());

            Console.WriteLine("---------------------------------------------------");
            /*----------------------------------------------------------------*/

            //mis methodos encontrados en internet

            string name = "joel";
            string apellido = "barrantes";

            //Length
            //devuelve la longitud de la variable
            Console.WriteLine(name.Length);

            //Concat
            //concatena dos string
            string NombreCompleto = string.Concat(name, " ",apellido);
            Console.WriteLine(NombreCompleto);

            //acces to a variable string like a list
            Console.WriteLine(NombreCompleto[1]);

            //backslash escape character
            string amigo = "este es un amigo \"joan\" ";
            Console.WriteLine(amigo);











        }
    }
}
