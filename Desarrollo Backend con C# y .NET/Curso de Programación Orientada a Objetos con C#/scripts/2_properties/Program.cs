// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;
// superman.SuperPoderes = new []{ "Vision de rayos X", "Volar", "Super fueza", "Ojos rayos lazer" };

List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;

class SuperHeroe
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string IdentidadSecreta { get; set; }
    public string Ciudad { get; set; }
    public List<SuperPoder> SuperPoderes { get; set; }
    public bool PuedeVolar { get; set; }
}

class SuperPoder
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public NivelPoder Nivel { get; set; }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}


