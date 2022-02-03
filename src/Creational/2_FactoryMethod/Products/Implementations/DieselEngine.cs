namespace DesignPattern.Creational.FactoryMethod.Products.Implementations;

using DesignPattern.Creational.FactoryMethod.Products.Abstractions;

internal class DieselEngine : IEngine
{
    public String GetDetails() => $"EngineType: {nameof(DieselEngine)}, Cylinders: 2;";
}
