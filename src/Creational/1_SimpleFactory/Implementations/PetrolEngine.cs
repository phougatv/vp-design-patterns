namespace DesignPatterns.Creational.SimpleFactory.Implementations;

using DesignPatterns.Creational.SimpleFactory.Abstractions;

internal class PetrolEngine : Engine
{
    #region Private Constants
    private const String PETROL = "Petrol";
    #endregion Private Constants

    #region Public Ctors
    /// <summary> Creates an instance of <see cref="PetrolEngine"/> with default number of cylinders, 4. </summary>
    public PetrolEngine()
        : this(4)
    {

    }

    /// <summary> Create instances of <see cref="PetrolEngine"/> class. </summary>
    /// <param name="cylinders">The number of cylinders.</param>
    public PetrolEngine(Int32 cylinders)
        : base(cylinders, PETROL)
    {

    }
    #endregion Public Ctors

    #region Public Methods
    /// <summary> Prints the fuel type. </summary>
    public override String GetFuelTypeMessage() => $"{nameof(PetrolEngine)}: Fuel type is {FuelType}.";

    /// <summary> Prints the number of cylinders. </summary>
    public override String GetCylinderMessage() => $"{nameof(PetrolEngine)}: Number of cylinders is {Cylinders}.";
    #endregion Public Methods
}
