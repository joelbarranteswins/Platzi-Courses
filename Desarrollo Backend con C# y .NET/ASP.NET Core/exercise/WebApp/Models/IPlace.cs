namespace WebApp.Models;

public interface IPlace
{
    string Address { get; set; }

    void CleanPlace();

}
