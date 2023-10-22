using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class SuperPoder
    {
        public string Nombre;
        public string Descripcion;
        public NivelPoder Nivel;

        public SuperPoder()
        {
            Nivel = NivelPoder.NivelUno;
        }
    }
}
