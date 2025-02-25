// 4️⃣ Create a MaxLength Attribute for Field Validation
// Problem Statement: Define a field-level attribute MaxLength(int value) that restricts the maximum length of a string field.
// Requirements:
// Apply it to a User class field (Username).
// Validate length in the constructor.
// Throw ArgumentException if the limit is exceeded.
using System;
using System.Reflection;

//  Define the MaxLength attribute
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

// Apply the attribute and validate in the constructor
public class User
{
    [MaxLength(10)]
    public string Username { get; set; }

    public User(string username)
    {
        ValidateFieldLength(username, nameof(Username));
        Username = username;
    }

    private void ValidateFieldLength(string value, string propertyName)
    {
        PropertyInfo property = GetType().GetProperty(propertyName);
        var attribute = property.GetCustomAttribute<MaxLengthAttribute>();

        if (attribute != null && value.Length > attribute.Length)
        {
            throw new ArgumentException($"{propertyName} exceeds the maximum length of {attribute.Length} characters.");
        }
    }
}

// Test the validation
public class Program9
{
    public static void Main()
    {
        try
        {
            User validUser = new User("JohnDoe");
            Console.WriteLine($"User created: {validUser.Username}");

            User invalidUser = new User("ThisUsernameIsTooLong");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}




