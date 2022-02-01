namespace DesignPatterns.Creational.SimpleFactory.Factories;

using DesignPatterns.Creational.SimpleFactory.Abstractions;
using DesignPatterns.Creational.SimpleFactory.Enums;
using DesignPatterns.Creational.SimpleFactory.Utils;
using DesignPatterns.Shared.Exceptions;
using DesignPatterns.Shared.Utils;
using System;

public class EngineFactory
{
    private static readonly IDictionary<EngineType, String> _engineTypeMap = FileReader.ReadConfigFile<EngineType, String>();

    public static Engine BuildEngine(EngineType engineType)
        => InternalBuildEngine(engineType);

    private static Engine InternalBuildEngine(EngineType engineType)
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
