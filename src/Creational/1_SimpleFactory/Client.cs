namespace DesignPattern.Creational.SimpleFactory;

using DesignPattern.Creational.SimpleFactory.Enums;
using DesignPattern.Creational.SimpleFactory.Factories;
using Microsoft.Extensions.Configuration;
using static System.Console;

internal class Client
{
    internal static void Init()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("Configurations/configuration.json")
            .Build();
        var engineTypeKey = config
            .GetSection("EngineType")
            .Get<EngineType>();

        WriteLine("---- ---- Engine creation begins... ---- ----");

        var engine = EngineBuilder.Build(engineTypeKey);
        WriteLine($"{engine.GetEngineDetails()}");

        WriteLine("---- ---- Engine created... ---- ----");
    }
}
