namespace DesignPattern.Shared.Utils;

using DesignPattern.Shared.Exceptions;
using Microsoft.Extensions.Configuration;

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

    #region Configuration Extension Methods
    public static IDictionary<TKey, TValue> GetMap<TKey, TValue>(this IConfiguration configuration, String sectionKey)
        where TKey : notnull
    {
        if (configuration == null)
            Throw.ArgumentNullException(nameof(configuration));
        if (sectionKey.IsNullOrEmpty())
            Throw.ArgumentNullException($"{nameof(sectionKey)} must not be null/empty.");

        var configSectionValue = configuration.GetRequiredSection(sectionKey);
        if (configSectionValue == null)
            Throw.Exception($"{sectionKey} must have a value.");

        return configSectionValue.Get<IDictionary<TKey, TValue>>();
    }
    #endregion Configuration Extension Methods

    #region ConfigurationBuilder Extension Methods
    public static IConfiguration GetConfiguration(this ConfigurationBuilder builder, String fullyQualifiedFilePathWithExtension)
    {
        if (builder == null)
            Throw.ArgumentNullException(nameof(builder));
        if (!Path.HasExtension(fullyQualifiedFilePathWithExtension))
            Throw.Exception($"{nameof(fullyQualifiedFilePathWithExtension)} must have extension (.json, .txt etc.).");
        
        return builder.AddJsonFile(fullyQualifiedFilePathWithExtension).Build();
    }
    #endregion ConfigurationBuilder Extension Methods

    #region IDictionary Extension Methods
    public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> map, TKey key)
        where TKey : notnull
    {
        if (map == null)
            Throw.ArgumentNullException(nameof(map));
        if (map.TryGetValue(key, out var value))
            return value;

        return default;
    }
    #endregion IDictionary Extension Methods

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
