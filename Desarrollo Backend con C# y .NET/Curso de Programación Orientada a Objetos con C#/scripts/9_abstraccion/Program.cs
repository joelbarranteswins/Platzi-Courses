
using System.Text;
using SuperHeroesApp.Models;

var poderVolar = new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear en el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;

var regeneracion = new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelTres;

var superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "   Superman   ";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;


List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

var wolverine = new AntiHeroe();
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);