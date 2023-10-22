using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Heroe, ISuperHeroe
    {
        public SuperHeroe()
        {
            Id = 1;
            SuperPoderes = new List<SuperPoder>();
            PuedeVolar = false;
        }

        private string nombre;
        public int Id {get; set; }
        public override string Nombre 
        { 
            get
            {
                return nombre;
            }
            
            set
            {
                nombre = value.Trim();
            }
        }

        public string NombreEIdentidadSecreta
        {
            get
            {
                return $"{Nombre} ({IdentidadSecreta})";
            }
        }


        public string IdentidadSecreta {get; set; }
        public string Ciudad;
        public List<SuperPoder> SuperPoderes;
        public bool PuedeVolar;

        

        public string UsarSuperPoderes()
        {
            StringBuilder sb = new();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre}!!");
            }

            return sb.ToString();
        }

        public override string SalvarElMundo()
        {
            return $"{NombreEIdentidadSecreta} ha salvado el mundo";
        }

        public override string SalvarLaTierra()
        {
            return $"{NombreEIdentidadSecreta} ha salvado la tierra";
        }
    }

}
