namespace DesignPatterns.Creational.SimpleFactory.Utils;

using DesignPatterns.Creational.SimpleFactory.Enums;

internal static class Extensions
{
    #region Engine Extension Methods
    public static String GetName(this EngineType engineType) => Enum.GetName(engineType) ?? "DefaultEngine";
    public static Boolean IsDefault(this EngineType engineType) => engineType == EngineType.DefaultEngine;
    public static Boolean IsDiesel(this EngineType engineType) => engineType == EngineType.DieselEngine;
    public static Boolean IsPetrol(this EngineType engineType) => engineType == EngineType.PetrolEngine;
    public static Boolean IsValid(this EngineType engineType) => Enum.IsDefined(engineType);
    #endregion Engine Extension Methods
}
