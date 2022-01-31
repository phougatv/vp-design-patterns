namespace DesignPatterns.Shared.Exceptions;



public static class Throw
{
    #region ArgumentNull Exception
    public static void ArgumentNullException(String paramName)
        => throw new ArgumentNullException(paramName);

    public static void ArgumentNullException(String paramName, String message)
        => throw new ArgumentNullException(paramName, message);

    public static void ArgumentNullException(String message, Exception innerException)
        => throw new ArgumentNullException(message, innerException);
    #endregion ArgumentNull Exception

    #region ArgumentOutOfRange Exception
    public static void ArgumentOutOfRangeException(String paramName, String message)
        => throw new ArgumentOutOfRangeException(paramName, message);
    #endregion

    #region Exception
    public static void Exception(String message)
        => throw new Exception(message);
    #endregion Exception

    #region TypeLoad Exception
    public static void TypeLoadException(String message)
        => throw new TypeLoadException(message);
    #endregion TypeLoad Exception
}
