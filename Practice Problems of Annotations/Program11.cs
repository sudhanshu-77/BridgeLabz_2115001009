
// 6️⃣ Implement a Custom Serialization Attribute JsonField
// Problem Statement: Define an attribute JsonField to mark fields for JSON serialization.
// Requirements:
// [JsonField(Name = "user_name")] should map field names to custom JSON keys.
// Apply it on a User class.
// Write a method to convert an object to a JSON string by reading the attributes.
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

//  custom attribute JsonField
[AttributeUsage(AttributeTargets.Property)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

//  User class with JsonField attributes
public class User
{
    [JsonField(Name = "user_name")]
    public string Name { get; set; }

    [JsonField(Name = "user_email")]
    public string Email { get; set; }

    [JsonField(Name = "user_age")]
    public int Age { get; set; }
}

public class JsonSerializer
{
    // Method to convert an object to a JSON string using JsonField attributes
    public static string SerializeToJson(object obj)
    {
        var jsonDict = new Dictionary<string, object>();
        var properties = obj.GetType().GetProperties();

        foreach (var property in properties)
        {
            var jsonFieldAttribute = property.GetCustomAttribute<JsonFieldAttribute>();
            if (jsonFieldAttribute != null)
            {
                var jsonKey = jsonFieldAttribute.Name;
                var value = property.GetValue(obj);
                jsonDict[jsonKey] = value;
            }
        }

        return JsonSerializer.Serialize(jsonDict);
    }
}

public class Program11
{
    public static void Main()
    {
        User user = new User
        {
            Name = "John Doe",
            Email = "john.doe@example.com",
            Age = 30
        };

        string jsonString = JsonSerializer.SerializeToJson(user);
        Console.WriteLine(jsonString);
    }
}



