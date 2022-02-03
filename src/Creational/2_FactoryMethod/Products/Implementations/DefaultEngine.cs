namespace DesignPattern.Creational.FactoryMethod.Products.Implementations;

using DesignPattern.Creational.FactoryMethod.Products.Abstractions;

internal class DefaultEngine : IEngine
{
    public String GetDetails() => $"EngineType: {nameof(DefaultEngine)}, Cylinders: 0;";
}
