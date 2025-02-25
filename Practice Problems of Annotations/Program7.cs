
// 2️⃣ Create a Todo Attribute for Pending Tasks
// Problem Statement: Define an attribute Todo to mark pending features in a project.
// Requirements:
// The attribute should have fields: 
// Task (string) → Description of the task
// AssignedTo (string) → Developer responsible
// Priority (default: "MEDIUM")
// Apply it to multiple methods.
// Retrieve and print all pending tasks using Reflection.
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

public class ProjectManager
{
    [Todo("Implement login feature", "Alice", "HIGH")]
    public void LoginFeature()
    {
        Console.WriteLine("Working on Login Feature...");
    }

    [Todo("Add user profile section", "Bob")]
    public void UserProfileFeature()
    {
        Console.WriteLine("Working on User Profile...");
    }

    [Todo("Optimize database queries", "Charlie", "LOW")]
    public void OptimizeDatabase()
    {
        Console.WriteLine("Optimizing Database...");
    }
}

public class Program7
{
    public static void Main()
    {
        ProjectManager manager = new ProjectManager();
        manager.LoginFeature();
        manager.UserProfileFeature();
        manager.OptimizeDatabase();

        Console.WriteLine("\nPending Tasks:");
        MethodInfo[] methods = typeof(ProjectManager).GetMethods();

        foreach (MethodInfo method in methods)
        {
            var attributes = method.GetCustomAttributes<TodoAttribute>();
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"- Task: {attribute.Task}");
                Console.WriteLine($"  Assigned To: {attribute.AssignedTo}");
                Console.WriteLine($"  Priority: {attribute.Priority}");
                Console.WriteLine($"  Method: {method.Name}\n");
            }
        }
    }
}



