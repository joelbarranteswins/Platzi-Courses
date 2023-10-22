using System.Text;

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

var superman2 = new SuperHeroe();

superman2.Id = 1;
superman2.Nombre = "Superman";
superman2.IdentidadSecreta = "Clark Kent";
superman2.Ciudad = "Metropolis";
superman2.PuedeVolar = true;

Console.WriteLine(superman == superman2);

SuperHeroRecord superHeroRecord = new(1, "Superman", "Clark Kent");
SuperHeroRecord superHeroRecord2 = new(1, "Superman", "Clark Kent");

Console.Write(superHeroRecord == superHeroRecord2);

//List<SuperPoder> poderesSuperman = new List<SuperPoder>();
//poderesSuperman.Add(poderVolar);
//poderesSuperman.Add(superFuerza);
//superman.SuperPoderes = poderesSuperman;
//string resultSuperPoderes = superman.UsarSuperPoderes();
//Console.WriteLine(resultSuperPoderes);

class SuperHeroe
{
    public int Id = 1;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes = new List<SuperPoder>();
    public bool PuedeVolar;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;
    }

    public string UsarSuperPoderes()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in SuperPoderes)
        {
            sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!!");
        }

        return sb.ToString();
    }
}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}

public record SuperHeroRecord(int Id, string Nombre, string IdentidadSecreta);