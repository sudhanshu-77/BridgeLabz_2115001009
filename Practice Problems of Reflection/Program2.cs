// Access Private Field: Create a class Person with a private field age. Use Reflection to modify and retrieve its value. 
using System;
using System.Reflection;

public class Person
{
    private int age = 25;
}

public class Program2
{
    public static void Main()
    {
        Person person = new Person();
        Type type = typeof(Person);
        
        FieldInfo ageField = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (ageField != null)
        {
            Console.WriteLine("Original Age: " + ageField.GetValue(person));

            ageField.SetValue(person, 30);
            Console.WriteLine("Updated Age: " + ageField.GetValue(person));
        }
    }
}



