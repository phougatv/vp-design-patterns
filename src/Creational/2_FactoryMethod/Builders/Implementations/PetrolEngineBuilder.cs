namespace DesignPattern.Creational.FactoryMethod.Builders.Implementations;

using DesignPattern.Creational.FactoryMethod.Builders.Abstractions;
using DesignPattern.Creational.FactoryMethod.Products.Abstractions;
using DesignPattern.Creational.FactoryMethod.Products.Implementations;

internal class PetrolEngineBuilder : EngineBuilder
{
    public override IEngine Build() => new PetrolEngine();
}
