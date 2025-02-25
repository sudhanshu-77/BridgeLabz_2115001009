// 5️⃣ Implement Role-Based Access Control with RoleAllowed
// Problem Statement: Define a class-level attribute RoleAllowed to restrict method access based on roles.
// Requirements:
// [RoleAllowed("ADMIN")] should only allow ADMIN users to execute the method.
// Simulate user roles and validate access before invoking the method.
// If a non-admin tries to access it, print Access Denied!
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

public class User
{
    public string Username { get; set; }
    public string Role { get; set; }

    public User(string username, string role)
    {
        Username = username;
        Role = role;
    }
}

public class SecureService
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed!");
    }

    [RoleAllowed("USER")]
    public void UserTask()
    {
        Console.WriteLine("User task executed!");
    }
}

public class AccessController
{
    public static void ExecuteIfAuthorized(object obj, string methodName, User user)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);
        var attribute = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attribute != null)
        {
            if (user.Role.Equals(attribute.Role, StringComparison.OrdinalIgnoreCase))
            {
                method.Invoke(obj, null);
            }
            else
            {
                Console.WriteLine($"Access Denied! {user.Username} does not have permission to execute {methodName}.");
            }
        }
        else
        {
            method.Invoke(obj, null);
        }
    }
}

public class Program10
{
    public static void Main()
    {
        SecureService service = new SecureService();
       
        User admin = new User("Alice", "ADMIN");
        User regularUser = new User("Bob", "USER");

        Console.WriteLine($"Attempting with admin user: {admin.Username}");
        AccessController.ExecuteIfAuthorized(service, "AdminTask", admin);

        Console.WriteLine($"\nAttempting with regular user: {regularUser.Username}");
        AccessController.ExecuteIfAuthorized(service, "AdminTask", regularUser);

        Console.WriteLine($"\nRegular user accessing user task:");
        AccessController.ExecuteIfAuthorized(service, "UserTask", regularUser);
    }
}



