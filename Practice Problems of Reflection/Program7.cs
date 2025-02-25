// Access and Modify Static Fields: Create a Configuration class with a private static field API_KEY. Use Reflection to modify its value and print it.
using System;
using System.Reflection;

public class Configuration
{
    private static string API_KEY = "original_key";

    public static void PrintApiKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

public class Program7
{
    public static void Main()
    {
        Type type = typeof(Configuration);

        // Access private static field
        FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        // Print original value
        Configuration.PrintApiKey();

        // Modify field value
        field.SetValue(null, "new_key");

        // Print modified value
        Configuration.PrintApiKey();
    }
}

