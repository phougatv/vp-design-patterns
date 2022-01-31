namespace DesignPatterns.Creational.SimpleFactory.Abstractions;

using System;

public abstract class Engine : IEquatable<Engine>
{
    #region Protected Constants
    protected const String DEFAULT = "Default";
    #endregion Protected Constants

    #region Public Properties
    /// <summary> Gets the number of Cylinders. </summary>
    public Int32 Cylinders { get; }

    /// <summary> Gets the type of the fuel. </summary>
    public String FuelType { get; }
    #endregion Public Properties

    #region Protected Ctors
    /// <summary> Create instances of <see cref="Engine"/> class. </summary>
    /// <param name="cylinders">The number of cylinders.</param>
    protected Engine(Int32 cylinders, String fuelType)
    {
        if (cylinders < 0)
            throw new ArgumentOutOfRangeException(nameof(cylinders));
        if (String.IsNullOrEmpty(fuelType))
            throw new ArgumentNullException(nameof(fuelType));
        if (cylinders == 0 && !fuelType.Equals(DEFAULT))
            throw new ArgumentException($"Cylinders cannot be 0 for fuel type: {fuelType}.", nameof(cylinders));

        Cylinders = cylinders;
        FuelType = fuelType;
    }
    #endregion Protected Ctors

    #region Protected Static Methods
    /// <summary> Prints the message. </summary>
    /// <param name="message">The message.</param>
    protected static void Print(String message) => Console.WriteLine(message);
    #endregion Protected Static Methods

    #region Public Abstract Methods
    public abstract String GetFuelTypeMessage();
    public abstract String GetCylinderMessage();
    #endregion Public Abstract Methods

    #region Overriding Equals and GetHashCode Methods
    /// <summary> Compares the instances of engines. </summary>
    /// <param name="obj">The obj.</param>
    /// <returns>True if equal, false otherwise.</returns>
    public override Boolean Equals(Object? obj) => (obj is Engine engine) && Equals(engine);

    /// <summary> Gets the hash code. </summary>
    /// <returns></returns>
    public override Int32 GetHashCode() => DesignPatterns.Shared.Utils.HashCode.Of(Cylinders).And(FuelType);
    #endregion Overriding Equals and GetHashCode Methods

    #region Public Virtual Methods
    /// <summary> Compares the instances of engines. </summary>
    /// <param name="engine">The engine <see cref="Engine"/>.</param>
    /// <returns>True if equal, false otherwise.</returns>
    public Boolean Equals(Engine? engine)
    {
        if (ReferenceEquals(this, engine))
            return true;
        if (engine is null)
            return false;

        return engine.Cylinders == Cylinders && engine.FuelType == FuelType;
    }
    #endregion Public Virtual Methods

    #region Operator Overloading
    public static Boolean operator ==(Engine left, Engine right)
    {
        if (ReferenceEquals(left, right))
            return true;
        if (left is null)
            return false;
        if (right is null)
            return false;

        return left.Equals(right);
    }
    public static Boolean operator !=(Engine left, Engine right) => !(left == right);
    #endregion Operator Overloading
}
