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
        var cylinders = 0;
        if (!args.IsEmpty())
        {
            engineKey = args[0];

            if (args.Length == 2)
                cylinders = Int32.Parse(args[1]);
        }

        WriteLine("---- ---- Engine creation begins... ---- ----");

        var engineTypeKey = engineKey.GetEnumValue<EngineType>();
        var engine = cylinders == 0 ?
            EngineFactory.GetEngine(engineTypeKey):
            EngineFactory.GetEngine(engineTypeKey, cylinders);
        WriteLine($"{engine.GetEngineDetails()}");

        WriteLine("---- ---- Engine created... ---- ----");
    }
}