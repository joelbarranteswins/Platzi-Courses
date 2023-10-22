using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    internal class AntiHeroe : SuperHeroe
    {
        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El Antiheroe {NombreEIdentidadSecreta} ha realizado: {accion}";
        }
    }
}
