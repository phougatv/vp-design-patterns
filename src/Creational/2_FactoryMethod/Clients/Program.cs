using DesignPattern.Creational.FactoryMethod.Enums;
//using DesignPattern.Creational.FactoryMethod.Factories.Abstractions;
//using DesignPattern.Shared.Utils;
//using Microsoft.Extensions.Configuration;
//using static System.Console;

//var configFilePath = "Configurations\\configuration.json";
//var engineTypeConfigKey = "EngineType";
//var engineTypeBuilderMapConfigKey = "EngineTypeBuilderMap";
//var engineBuilderClassMapConfigKey = "EngineBuilderClassMap";

//var config = new ConfigurationBuilder().GetConfiguration(configFilePath);
//var engineType = config[engineTypeConfigKey].GetEnumValue<EngineType>();
//var engineTypeBuilderMap = config.GetMap<EngineType, String>(engineTypeBuilderMapConfigKey);
//var engineBuilderClassMap = config.GetMap<String, String>(engineBuilderClassMapConfigKey);

//var engineBuilderKey = engineTypeBuilderMap.GetValue(engineType);
//var engineBuilderClassName = engineBuilderClassMap.GetValue(engineBuilderKey);
//var type = Type.GetType(engineBuilderClassName);
//if (type == null)
//    throw new Exception($"{nameof(type)} must not be null.");

//if (Activator.CreateInstance(type) is not EngineBuilder engineBuilder)
//    throw new Exception($"{nameof(engineBuilder)} must not be null.");

//var engine = engineBuilder.Build();
//WriteLine(engine.GetDetails());

namespace DesignPattern.Creational.FactoryMethod.Clients;

using DesignPattern.Creational.FactoryMethod.Factories.Abstractions;
using DesignPattern.Creational.FactoryMethod.Factories.Implementations;
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
    private static readonly String _engineTypeConfigKey = "EngineType";
    private static readonly String _engineTypeBuilderMapConfigKey = "EngineTypeBuilderMap";
    private static readonly String _engineBuilderClassMapConfigKey = "EngineBuilderClassMap";
    private static readonly EngineType _engineTypeKey;
    private static readonly IDictionary<EngineType, String> _engineTypeBuilderMap;
    private static readonly IDictionary<String, String> _engineBuilderClassMap;

    static Client()
    {
        var config = new ConfigurationBuilder().GetConfiguration(_configFilePathWithExtension);
        _engineTypeKey = config[_engineTypeConfigKey].GetEnumValue<EngineType>();
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
