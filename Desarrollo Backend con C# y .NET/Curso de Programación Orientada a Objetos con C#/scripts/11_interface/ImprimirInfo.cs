using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal static class ImprimirInfo
    {
        public static void ImprimirSuperHeroe(ISuperHeroe superHeroe)
        {
            //Console.WriteLine($"Id: {superHeroe.Id}");
            //Console.WriteLine($"Nombre: {superHeroe.Nombre}");
            //Console.WriteLine($"Identidad Secreta: {superHeroe.IdentidadSecreta}");
             
            Console.WriteLine(superHeroe.GetSuperHeroe());
        }
    }
}
