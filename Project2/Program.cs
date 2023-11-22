global using Microsoft.Extensions.DependencyInjection;
using Project2;

// Microsoft.Extensions.DependencyInjection

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<ConsoleController>(); // view
serviceCollection.AddTransient<IMyApiService, MongoApiService>();
serviceCollection.AddTransient<Random>(_ =>
{
    return new Random(1337);
});


var provider = serviceCollection.BuildServiceProvider();
var controller = provider.GetService<ConsoleController>()!; // startup service

// ...

controller.WriteData();


public class ConsoleController
{
    private IMyApiService _apiService;
    
    public ConsoleController(IMyApiService myApiService)
    {
        _apiService = myApiService;
    }

    public void WriteData()
    {
        foreach (var value in _apiService.GetData())
        {
            Console.WriteLine(value);
        }
    }
}



