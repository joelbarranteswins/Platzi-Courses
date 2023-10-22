
using System.Text;
using SuperHeroesApp;
using SuperHeroesApp.Models;



SuperPoder poderVolar = new()
{
    Nombre = "Volar",
    Descripcion = "Capacidad para volar y planear en el aire",
    Nivel = NivelPoder.NivelDos
};



SuperPoder superFuerza = new()
{
    Nombre = "Super fuerza",
    Nivel = NivelPoder.NivelTres
};

SuperPoder regeneracion = new()
{
    Nombre = "Regeneración",
    Nivel = NivelPoder.NivelTres
};

var superman = new SuperHeroe
{
    Id = 1,
    Nombre = "   Superman   ",
    IdentidadSecreta = "Clark Kent",
    Ciudad = "Metropolis",
    PuedeVolar = true
};

ImprimirInfo.ImprimirSuperHeroe(superman);


List<SuperPoder> poderesSuperman = new()
{
    poderVolar,
    superFuerza
};
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);
string resultSalvarMundo = superman.SalvarElMundo();
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

AntiHeroe wolverine = new()
{
    Id = 5,
    Nombre = "Wolverine",
    IdentidadSecreta = "Logan",
    PuedeVolar = false
};

ImprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new()
{
    regeneracion,
    superFuerza
};
wolverine.SuperPoderes = poderesWolverine;
string resultWolverinePoderes = wolverine.UsarSuperPoderes();
Console.WriteLine(resultWolverinePoderes);

string accionAntiheroe = wolverine.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiheroe);

