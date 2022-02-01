namespace DesignPattern.Creational.SimpleFactory.Implementations;

using DesignPattern.Creational.SimpleFactory.Abstractions;

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
    public override String GetEngineDetails() => $"{nameof(DefaultEngine)}: Fuel type is {FuelType} and has {Cylinders} cylinders.";
    #endregion Public Methods
}
