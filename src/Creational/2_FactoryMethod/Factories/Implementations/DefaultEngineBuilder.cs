﻿namespace DesignPattern.Creational.FactoryMethod.Factories.Implementations;

using DesignPattern.Creational.FactoryMethod.Factories.Abstractions;
using DesignPattern.Creational.FactoryMethod.Products.Abstractions;
using DesignPattern.Creational.FactoryMethod.Products.Implementations;

internal class DefaultEngineBuilder : EngineBuilder
{
    public override IEngine Build() => new DefaultEngine();
}
