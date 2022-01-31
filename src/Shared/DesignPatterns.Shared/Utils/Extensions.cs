namespace DesignPatterns.Shared.Utils;

using DesignPatterns.Shared.Exceptions;

public static class Extensions
{
    #region Type Extension Methods
    public static Boolean IsNull(this Type type) => type == null;
    #endregion Type Extension Methods

    #region Enum Extension Methods
    public static T GetEnumValue<T>(this String str)
        where T : struct, IConvertible
    {
        var enumType = typeof(T);
        if (!enumType.IsEnum)
            Throw.Exception("T must be an Enumeration type.");

        return Enum.TryParse(str, true, out T val) ? val : default;
    }

    public static T GetEnumValue<T>(this Int32 i32)
    {
        var enumType = typeof(T);
        if (!enumType.IsEnum)
            Throw.Exception("T must be an Enumeration type.");

        return (T)Enum.ToObject(enumType, i32);
    }
    #endregion Enum Extension Methods

    #region Array Extension Methods
    public static Boolean IsEmpty(this Array array) => array.Length == 0;
    #endregion Array Extension Methods

    #region String Extension Methods
    public static Boolean IsEmpty(this String str) => str.Length <= 0;
    public static Boolean IsNull(this String str) => str == null;
    public static Boolean IsNullOrEmpty(this String str) => String.IsNullOrEmpty(str);
    public static Boolean IsNullOrWhiteSpace(this String str) => String.IsNullOrWhiteSpace(str);
    #endregion String Extension Methods

    #region Int32 Extension Methods
    public static Boolean IsEven(this Int32 i32) => (i32 & 1) == 0;
    public static Boolean IsNegative(this Int32 i32) => i32 < 0;
    public static Boolean IsOdd(this Int32 i32) => (i32 & 1) == 1;
    public static Boolean IsPositive(this Int32 i32) => i32 > 0;
    public static Boolean IsZero(this Int32 i32) => i32 == 0;
    #endregion Int32 Extension Methods
}
