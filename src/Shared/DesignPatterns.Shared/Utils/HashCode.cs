namespace DesignPatterns.Shared.Utils;

using System;
using System.Collections.Generic;

/// <summary>
/// HasdCode struct, to help with implementing <see cref="Object.GetHashCode()"/>.
/// The code has been borrowed without asking from Rehan Saeed - https://rehansaeed.com/gethashcode-made-easy
/// </summary>
public struct HashCode : IEquatable<HashCode>
{
    private const Int32 EmptyCollectionPrimeNumber = 3079;
    private readonly Int32 _value;

    /// <summary> Initializes a new instance of <see cref="HashCode"/> struct. </summary>
    /// <param name="value">The value.</param>
    public HashCode(Int32 value)
    {
        _value = value;
    }

    #region Public Operator Overload Methods
    /// <summary> Performs an implicit conversion from <see cref="HashCode"/> to <see cref="Int32"/>. </summary>
    /// <param name="hashCode">The hash code <see cref="HashCode"/>.</param>
    public static implicit operator Int32(HashCode hashCode) => hashCode._value;

    /// <summary> Implements the == operator. </summary>
    /// <param name="left">The left hash code.</param>
    /// <param name="right">The right hash code.</param>
    /// <returns>true if equal, false otherwise.</returns>
    public static Boolean operator ==(HashCode left, HashCode right) => left.Equals(right);

    /// <summary> Implements the != operator. </summary>
    /// <param name="left">The left hash code.</param>
    /// <param name="right">The right hash code.</param>
    /// <returns>true if not equal, false otherwise.</returns>
    public static Boolean operator !=(HashCode left, HashCode right) => !left.Equals(right);
    #endregion Public Operator Overload Methods

    #region Public Equals Methods
    public Boolean Equals(HashCode hashCode) => _value.Equals(hashCode._value);

    public override Boolean Equals(Object? obj) => (obj is HashCode code) && Equals(code);
    #endregion

    #region Added recently
    /// <summary>
    /// Takes the hash code of the specified item.
    /// </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    /// <param name="item">The item.</param>
    /// <returns>The new hash code.</returns>
    public static HashCode Of<T>(T item) => new HashCode(GetHashCode(item));

    /// <summary> Takes the hash code of the specified items. </summary>
    /// <typeparam name="T">The type of the items.</typeparam>
    /// <param name="items">The collection.</param>
    /// <returns>The new hash code.</returns>
    public static HashCode OfEach<T>(IEnumerable<T> items) => items == null ? new HashCode(0) : new HashCode(GetHashCode(items, 0));

    /// <summary> Adds the hash code of the specified item. </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    /// <param name="item">The item.</param>
    /// <returns>The new hash code.</returns>
    public HashCode And<T>(T item) => new HashCode(CombineHashCodes(_value, GetHashCode(item)));

    /// <summary> Adds the hash code of the specified items in the collection. </summary>
    /// <typeparam name="T">The type of the items.</typeparam>
    /// <param name="items">The collection.</param>
    /// <returns>The new hash code.</returns>
    public HashCode AndEach<T>(IEnumerable<T> items) => items == null ? new HashCode(_value) : new HashCode(GetHashCode(items, _value));
    #endregion Added recently

    #region Private Methods
    private static Int32 CombineHashCodes(Int32 h1, Int32 h2)
    {
        unchecked
        {
            // Code copied from System.Tuple so it must be the best way to combine hash codes or at least a good one.
            return ((h1 << 5) + h1) ^ h2;
        }
    }

    private static Int32 GetHashCode<T>(T item)
    {
        if (item == null)
            throw new ArgumentNullException(nameof(item));

        return item.GetHashCode();     //TODO: modify it to >>> item.GetHashCode() ?? 0;
    }

    private static Int32 GetHashCode<T>(IEnumerable<T> items, Int32 startHashCode)
    {
        var temp = startHashCode;
        var enumerator = items.GetEnumerator();
        if (enumerator.MoveNext())
        {
            temp = CombineHashCodes(temp, GetHashCode(enumerator.Current));
            while (enumerator.MoveNext())
                temp = CombineHashCodes(temp, GetHashCode(enumerator.Current));
        }
        else
            temp = CombineHashCodes(temp, EmptyCollectionPrimeNumber);

        return temp;
    }

    public override Int32 GetHashCode()
    {
        unchecked
        {
            return _value.GetHashCode() * 7919;
        }
    }
    #endregion Private Methods
}
