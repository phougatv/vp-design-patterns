namespace DesignPattern.Creational.FactoryMethod;

using DesignPattern.Creational.FactoryMethod.Builders.Abstractions;
using DesignPattern.Creational.FactoryMethod.Builders.Implementations;
using static System.Console;

internal class Client
{
    internal static void Init()
    {
        WriteLine($"{nameof(DefaultEngineBuilder)} execution begins...");
        InternalInit(new DefaultEngineBuilder());
        WriteLine();

        WriteLine($"{nameof(DieselEngineBuilder)} execution begins...");
        InternalInit(new DieselEngineBuilder());
        WriteLine();

        WriteLine($"{nameof(PetrolEngineBuilder)} execution begins...");
        InternalInit(new PetrolEngineBuilder());
        WriteLine();
    }

    private static void InternalInit(EngineBuilder engineBuilder)
        => WriteLine($"Client | {engineBuilder.SomeBusinessOperation()}");
}
