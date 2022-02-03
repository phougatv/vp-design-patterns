namespace DesignPattern.Creational.FactoryMethod.Products.Implementations;

using DesignPattern.Creational.FactoryMethod.Products.Abstractions;

internal class PetrolEngine : IEngine
{
    public String GetDetails() => $"EngineType: {nameof(PetrolEngine)}, Cylinders: 4;";
}
