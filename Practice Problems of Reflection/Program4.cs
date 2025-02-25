// Dynamically Create Objects: Write a program to create an instance of a Student class dynamically using Reflection without using the new keyword.
using System;
using System.Reflection;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student() { }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student ID: {Id}, Name: {Name}");
    }
}

public class Program4
{
    public static void Main()
    {
        Type type = typeof(Student);

        object studentObj = Activator.CreateInstance(type);
        
        PropertyInfo idProp = type.GetProperty("Id");
        PropertyInfo nameProp = type.GetProperty("Name");

        idProp.SetValue(studentObj, 101);
        nameProp.SetValue(studentObj, "Alice");

        MethodInfo displayMethod = type.GetMethod("DisplayInfo");
        displayMethod.Invoke(studentObj, null);
    }
}

