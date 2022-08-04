
namespace webapi.Services;
public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World!, Este es un mensaje del metodo Get :-)";
    }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}