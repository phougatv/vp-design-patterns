namespace DesignPatterns.Creational.SimpleFactory.Implementations;

using DesignPatterns.Creational.SimpleFactory.Abstractions;

internal class DefaultEngine : Engine
{
    #region Public Ctors
    public DefaultEngine()
        : base(0, DEFAULT)
    {
    }
    #endregion Public Ctors

    #region Public Methods
    /// <summary> Prints the fuel type. </summary>
    public override String GetFuelTypeMessage() => $"{nameof(DefaultEngine)}: Fuel type is {FuelType}.";

    /// <summary> Prints the number of cylinders. </summary>
    public override String GetCylinderMessage() => $"{nameof(DefaultEngine)}: Number of cylinders is {Cylinders}.";
    #endregion Public Methods
}
