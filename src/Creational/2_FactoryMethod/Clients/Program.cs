namespace DesignPattern.Creational.FactoryMethod.Clients;

using DesignPattern.Creational.FactoryMethod.Enums;
using DesignPattern.Creational.FactoryMethod.Factories.Abstractions;
using DesignPattern.Shared.Utils;
using Microsoft.Extensions.Configuration;
using static System.Console;

public class Program
{
    public static void Main()
    {
        var client = new Client();
        client.Init();
    }
}

public class Client
{
    private static readonly String _configFilePathWithExtension = "Configurations\\configuration.json";
    private static readonly String _engineTypeBuilderMapConfigKey = "EngineTypeBuilderMap";
    private static readonly String _engineBuilderClassMapConfigKey = "EngineBuilderClassMap";
    private static readonly IDictionary<EngineType, String> _engineTypeBuilderMap;
    private static readonly IDictionary<String, String> _engineBuilderClassMap;

    static Client()
    {
        var config = new ConfigurationBuilder().GetConfiguration(_configFilePathWithExtension);
        _engineTypeBuilderMap = config.GetMap<EngineType, String>(_engineTypeBuilderMapConfigKey);
        _engineBuilderClassMap = config.GetMap<String, String>(_engineBuilderClassMapConfigKey);
    }

    public void Init()
    {
        foreach (var engineTypeBuilderItem in _engineTypeBuilderMap)
        {
            var className = _engineBuilderClassMap.GetValue(engineTypeBuilderItem.Value);
            var type = Type.GetType(className);
            if (type.IsNull())
            {
                WriteLine($"Type is NULL for {engineTypeBuilderItem.Value}.");
                continue;
            }

            var engineBuilder = Activator.CreateInstance(type) as EngineBuilder;
            if (engineBuilder == null)
            {
                WriteLine($"EngineBuilder is NULL for {engineTypeBuilderItem.Value}.");
                continue;
            }

            WriteLine($"Launching application using {engineBuilder.GetType().Name}: ");
            Execute(engineBuilder);
            WriteLine();
        }
    }

    private void Execute(EngineBuilder engineBuilder) => WriteLine($"Client | {engineBuilder.SomeBusinessOperation()}");
}
