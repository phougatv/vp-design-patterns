namespace DesignPatterns.Creational.SimpleFactory;

using DesignPattern.Creational.SimpleFactory.Enums;
using DesignPattern.Creational.SimpleFactory.Factories;
using DesignPattern.Shared.Utils;
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