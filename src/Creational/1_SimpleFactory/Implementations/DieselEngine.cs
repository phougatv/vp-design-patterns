namespace DesignPatterns.Creational.SimpleFactory.Implementations;

using DesignPatterns.Creational.SimpleFactory.Abstractions;

internal class DieselEngine : Engine
{
    #region Private Constants
    private const String DIESEL = "Diesel";
    #endregion Private Constants

    #region Public Ctors
    /// <summary> Creates an instance of <see cref="DieselEngine"/> with default number of cylinders, 4. </summary>
    public DieselEngine()
        : this(2)
    {

    }

    /// <summary> Create instances of <see cref="DieselEngine"/> class. </summary>
    /// <param name="cylinders">The number of cylinders.</param>
    public DieselEngine(Int32 cylinders)
        : base(cylinders, DIESEL)
    {

    }
    #endregion Public Ctors

    #region Public Methods
    /// <summary> Prints the fuel type. </summary>
    public override String GetFuelTypeMessage() => $"{nameof(DieselEngine)}: Fuel type is {FuelType}.";

    /// <summary> Prints the number of cylinders. </summary>
    public override String GetCylinderMessage() => $"{nameof(DieselEngine)}: Number of cylinders is {Cylinders}.";
    #endregion Public Methods
}
