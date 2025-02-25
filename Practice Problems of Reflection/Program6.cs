
// Retrieve Attributes at Runtime: Create a custom attribute [Author("Author Name")]. Apply it to a class and use Reflection to retrieve and display the attribute value at runtime. 
using System;
using System.Reflection;

//  custom attribute Author
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Apply the Author attribute to a class
[Author("John Doe")]
public class SampleClass
{
}

public class Program6
{
    public static void Main()
    {
        Type type = typeof(SampleClass);
        var authorAttribute = (AuthorAttribute)type.GetCustomAttribute(typeof(AuthorAttribute));

        if (authorAttribute != null)
        {
            Console.WriteLine($"Author: {authorAttribute.Name}");
        }
        else
        {
            Console.WriteLine("Author attribute not found.");
        }
    }
}



