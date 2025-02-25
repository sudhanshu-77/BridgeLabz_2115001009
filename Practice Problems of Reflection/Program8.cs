
// 🔹 Advanced Level
// Create a Custom Object Mapper: Implement a method ToObject<T>(Type clazz, Dictionary<string, object> properties) that uses Reflection to set field values from a given dictionary. 
using System;
using System.Collections.Generic;
using System.Reflection;

public class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            PropertyInfo propertyInfo = type.GetProperty(prop.Key);
            if (propertyInfo != null && propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(obj, Convert.ChangeType(prop.Value, propertyInfo.PropertyType));
            }
        }

        return obj;
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program8
{
    public static void Main()
    {
        var properties = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 30 }
        };

        User user = ObjectMapper.ToObject<User>(properties);
        Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
    }
}

