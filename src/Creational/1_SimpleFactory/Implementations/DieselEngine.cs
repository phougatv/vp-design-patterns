namespace DesignPattern.Creational.SimpleFactory.Implementations;

using DesignPattern.Creational.SimpleFactory.Abstractions;

internal class DieselEngine : Engine
{
    #region Private Constants
    private const String DIESEL = "Diesel";
    #endregion Private Constants

    #region Public Ctors
    /// <summary> Creates an instance of <see cref="DieselEngine"/> with default number of cylinders, 4. </summary>
    public DieselEngine()
        : base(2, DIESEL)
    {

    }
    #endregion Public Ctors

    #region Public Methods
    /// <summary> Prints the fuel type. </summary>
    public override String GetEngineDetails() => $"{nameof(DieselEngine)}: Fuel type is {FuelType} and has {Cylinders} cylinders.";
    #endregion Public Methods
}
