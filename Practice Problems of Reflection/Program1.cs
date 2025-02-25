// tice Problems on Reflection in C#
// 🔹 Basic Level
// Get Class Information: Write a program to accept a class name as input and display its methods, fields, and constructors using Reflection.
using System;
using System.Reflection;

public class ExampClass
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ExampClass() { }
    public ExampClass(int id, string name) { }

    public void SayHello() => Console.WriteLine("Hello!");
}

public class Program1
{
    public static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();
        
        Type type = Type.GetType(className);

        if (type != null)
        {
            Console.WriteLine($"\nClass: {type.Name}");
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo ctor in type.GetConstructors())
            {
                Console.WriteLine(ctor.ToString());
            }
        }
        else
        {
            Console.WriteLine("Class not found!");
        }
    }
}

