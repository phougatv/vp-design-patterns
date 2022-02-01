namespace DesignPattern.Shared.Utils;

using DesignPattern.Shared.Exceptions;
using Newtonsoft.Json;

public class FileReader
{
    public static IDictionary<TKey, TValue> ReadConfigFile<TKey, TValue>()
        where TKey : notnull
        => ReadConfigFile<TKey, TValue>("./Configurations/configuration.json");

    public static IDictionary<TKey, TValue> ReadConfigFile<TKey, TValue>(String filePath)
        where TKey : notnull
    {
        if (filePath.IsNullOrEmpty())
            Throw.ArgumentNullException(nameof(filePath));
        if (!File.Exists(filePath))
            Throw.Exception($"File: {Path.GetFileName(filePath)} does not exists.");

        var text = File.ReadAllText(filePath);
        if (text.IsNullOrEmpty())
            return new Dictionary<TKey, TValue>();

        var map = JsonConvert.DeserializeObject<IDictionary<TKey, TValue>>(text);
        if (map == null)
            return new Dictionary<TKey, TValue>();

        return map;
    }
}
