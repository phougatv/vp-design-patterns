namespace DesignPatterns.Creational.SimpleFactory;

using DesignPatterns.Creational.SimpleFactory.Enums;
using DesignPatterns.Creational.SimpleFactory.Factories;
using DesignPatterns.Shared.Utils;
using static System.Console;

internal class Program
{
    public static void Main(String[] args)
    {
        var engineKey = "DefaultEngine";
        if (!args.IsEmpty())
            engineKey = args[0];

        WriteLine("---- ---- Engine creation begins... ---- ----");

        var engineTypeKey = engineKey.GetEnumValue<EngineType>();
        var engine = EngineFactory.BuildEngine(engineTypeKey);
        WriteLine($"{engine.GetEngineDetails()}");

        WriteLine("---- ---- Engine created... ---- ----");
    }
}