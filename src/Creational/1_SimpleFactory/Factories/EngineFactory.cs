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

    public static Engine GetEngine(EngineType engineType)
        => InternalGetEngine(engineType, 0);

    public static Engine GetEngine(EngineType engineType, Int32 cylinders)
    {
        if (cylinders.IsNegative())
            Throw.ArgumentOutOfRangeException(nameof(cylinders), $"{cylinders} must not be negative.");

        return InternalGetEngine(engineType, cylinders);
    }

    public static Engine InternalGetEngine(EngineType engineType, Int32 cylinders)
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

        var engine = ((engineType.IsDefault() || cylinders.IsZero()) ?
            Activator.CreateInstance(type) :
            Activator.CreateInstance(type, cylinders)) as Engine;

#pragma warning disable CS8603 // Possible null reference return.
        return engine;
#pragma warning restore CS8603 // Possible null reference return.
    }
}
