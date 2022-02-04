namespace DesignPattern.Creational.SimpleFactory.Products.Implementations;

using DesignPattern.Creational.SimpleFactory.Products.Abstractions;

internal class PetrolEngine : Engine
{
    #region Private Constants
    private const String PETROL = "Petrol";
    #endregion Private Constants

    #region Public Ctors
    /// <summary> Creates an instance of <see cref="PetrolEngine"/> with default number of cylinders, 4. </summary>
    public PetrolEngine()
        : base(4, PETROL)
    {

    }
    #endregion Public Ctors

    #region Public Methods
    /// <summary> Prints the fuel type. </summary>
    public override String GetEngineDetails() => $"{nameof(PetrolEngine)}: Fuel type is {FuelType} and has {Cylinders} cylinders.";
    #endregion Public Methods
}
