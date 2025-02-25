
// Exercise 4: Create a Custom Attribute and Use It
// Problem Statement: Create a custom attribute TaskInfo to mark tasks with priority and assigned person.
// Steps to Follow:
// Define an attribute TaskInfo with fields Priority and AssignedTo.
// Apply this attribute to a method in TaskManager class.
// Retrieve the attribute details using Reflection.
using System;
using System.Reflection;

// Define an enum for task priority
public enum Priority
{
    Low,
    Medium,
    High
}

// Define the custom attribute TaskInfo
[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public Priority TaskPriority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(Priority taskPriority, string assignedTo)
    {
        TaskPriority = taskPriority;
        AssignedTo = assignedTo;
    }
}

// Define the TaskManager class with a method marked with TaskInfo
public class TaskManager
{
    [TaskInfo(Priority.High, "Alice")]
    public void CompleteTask()
    {
        Console.WriteLine("Task completed.");
    }
}

public class Program4
{
    public static void Main()
    {
        TaskManager taskManager = new TaskManager();
        taskManager.CompleteTask();

        // Using reflection to retrieve the TaskInfo attribute details
        var method = typeof(TaskManager).GetMethod("CompleteTask");
        if (method.GetCustomAttribute(typeof(TaskInfoAttribute)) is TaskInfoAttribute taskInfo)
        {
            Console.WriteLine($"Task Priority: {taskInfo.TaskPriority}");
            Console.WriteLine($"Assigned To: {taskInfo.AssignedTo}");
        }
    }
}



