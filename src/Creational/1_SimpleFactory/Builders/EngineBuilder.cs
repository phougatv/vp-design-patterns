namespace DesignPattern.Creational.SimpleFactory.Factories;
using DesignPattern.Creational.SimpleFactory.Enums;
using DesignPattern.Creational.SimpleFactory.Products.Abstractions;
using DesignPattern.Creational.SimpleFactory.Products.Implementations;
using DesignPattern.Creational.SimpleFactory.Utils;
using DesignPattern.Shared.Exceptions;
using DesignPattern.Shared.Utils;
using System;

public class EngineBuilder
{
    private static readonly IDictionary<EngineType, String> _engineTypeMap = FileReader.ReadConfigFile<EngineType, String>();

    public static Engine Build(EngineType engineType)
        => InternalBuild(engineType);

    //If another type of engine is added then add an if statement and return that type of engine.
    private static Engine InternalBuild(EngineType engineType)
    {
        if (engineType.IsDiesel())
            return new DieselEngine();
        if (engineType.IsPetrol())
            return new PetrolEngine();

        return new DefaultEngine();
    }

    //I have used reflection in this.
    private static Engine InternalBuildUsingReflection(EngineType engineType)
    {
        if (!engineType.IsValid())
            Throw.ArgumentOutOfRangeException(nameof(engineType), $"{engineType} is invalid.");

        if (!_engineTypeMap.TryGetValue(engineType, out var fullyQualifiedClassName))
            Throw.ArgumentNullException(nameof(engineType), $"{engineType.GetName()} must have a fully qualified class-name.");

#pragma warning disable CS8604 // Possible null reference argument.
        if (fullyQualifiedClassName.IsNullOrEmpty())
            Throw.ArgumentNullException(nameof(engineType), $"{engineType.GetName()} must have a fully qualified class-name.");
#pragma warning restore CS8604 // Possible null reference argument.

        var type = Type.GetType(fullyQualifiedClassName);
#pragma warning disable CS8604 // Possible null reference argument.
        if (type.IsNull())
            Throw.TypeLoadException($"Failed to load type: {fullyQualifiedClassName}.");
#pragma warning restore CS8604 // Possible null reference argument.

        var engine = Activator.CreateInstance(type) as Engine;

#pragma warning disable CS8603 // Possible null reference return.
        return engine;
#pragma warning restore CS8603 // Possible null reference return.
    }
}
