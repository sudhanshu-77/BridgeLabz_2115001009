// Practice Problems for Custom Attributes in C#
// Beginner Level
// 1️⃣ Create an Attribute to Mark Important Methods
// Problem Statement: Define a custom attribute ImportantMethod that can be applied to methods to indicate their importance.
// Requirements:
// Define ImportantMethod with an optional Level parameter (default: "HIGH").
// Apply it to at least two methods.
// Retrieve and print annotated methods using Reflection.
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

public class TaskHandler
{
    [ImportantMethod("HIGH")]
    public void CriticalTask()
    {
        Console.WriteLine("Executing critical task...");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularTask()
    {
        Console.WriteLine("Executing regular task...");
    }

    public void OptionalTask()
    {
        Console.WriteLine("Executing optional task...");
    }
}

public class Program6
{
    public static void Main()
    {
        TaskHandler handler = new TaskHandler();
        handler.CriticalTask();
        handler.RegularTask();
        handler.OptionalTask();

     
        Console.WriteLine("\nImportant Methods:");
        MethodInfo[] methods = typeof(TaskHandler).GetMethods();

        foreach (MethodInfo method in methods)
        {
            var attribute = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attribute != null)
            {
                Console.WriteLine($"- {method.Name} (Level: {attribute.Level})");
            }
        }
    }
}




