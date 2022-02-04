namespace DesignPattern.Creational.FactoryMethod.Builders.Abstractions;

using DesignPattern.Creational.FactoryMethod.Products.Abstractions;

public abstract class EngineBuilder
{
    /// <summary>
    /// Creates instance of <see cref="IEngine"/>.
    /// </summary>
    /// <returns>Instance of <see cref="IEngine"/>.</returns>
    public abstract IEngine Build();

    /// <summary>
    /// Declares a method that perform some business operation
    /// </summary>
    public String SomeBusinessOperation()
    {
        //Call the factory method to create an object wrapped in IEngine.
        var engine = Build();

        //Now use the engine.
        var message = $"EngineBuilder | {engine.GetDetails()}.";

        return message;
    }
}
