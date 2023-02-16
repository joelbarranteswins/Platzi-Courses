namespace WebApp.Models;

public class School : ObjectSchoolBase
{
    //public new string? Name { get; set; }
    //public string? SchoolId { get; set; }
    public string? YearFundation { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Address { get; set; }
    public TypeSchool TypeSchool { get; set; }
    public List<Course>? Course{ get; set; }

    public void Escuela(string name, string yearFundation) => 
        (Name, YearFundation) = (name, yearFundation);

    public void Escuela(
        string name, string yearFundation,
        TypeSchool type,
        string country = "", string city = "")  
    {
        (Name, YearFundation) = (name, yearFundation);
        Country = country;
        City = city;
    }

    public override string ToString()
    {
        return $"Nombre: \"{Name}\", Tipo: {TypeSchool} " +
            $"{System.Environment.NewLine} Pais: {Country}, Ciudad:{City}";
    }
}

