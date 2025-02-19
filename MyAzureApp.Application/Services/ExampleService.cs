using MyAzureApp.Application.Services.interfaces;

public class ExampleService : IExampleService
{
    public string GetMessage()
    {
        return "Hello from ExampleService!";
    }
}