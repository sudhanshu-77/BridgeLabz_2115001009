
// Generate a JSON Representation: Write a program that converts an object to a JSON-like string using Reflection by inspecting its fields and values. 
using System;
using System.Text;
using System.Reflection;

public class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder sb = new StringBuilder("{");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        for (int i = 0; i < fields.Length; i++)
        {
            sb.Append($"\"{fields[i].Name}\": \"{fields[i].GetValue(obj)}\"");

            if (i < fields.Length - 1)
            {
                sb.Append(", ");
            }
        }

        sb.Append("}");
        return sb.ToString();
    }
}

public class Person
{
    public string FirstName;
    public string LastName;
}

public class Program9
{
    public static void Main()
    {
        Person person = new Person { FirstName = "John", LastName = "Doe" };

        string json = JsonConverter.ToJson(person);
        Console.WriteLine(json);
    }
}

