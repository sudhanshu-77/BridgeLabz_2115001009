// Exercise 5: Create and Use a Repeatable Attribute
// Problem Statement: Define an attribute BugReport that can be applied multiple times on a method.
// Steps to Follow:
// Define BugReport with a Description field.
// Use AllowMultiple = true to allow multiple bug reports.
// Apply it twice on a method.
// Retrieve and print all bug reports.
using System;
using System.Reflection;

// Define the repeatable attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }
    public string ReportedBy { get; }
    public string Date { get; }

    public BugReportAttribute(string description, string reportedBy, string date)
    {
        Description = description;
        ReportedBy = reportedBy;
        Date = date;
    }
}

//  Apply the attribute multiple times
public class Feature
{
    [BugReport("Null reference exception in edge case", "Alice", "2024-01-10")]
    [BugReport("UI alignment issue on mobile", "Bob", "2024-02-05")]
    public void LaunchFeature()
    {
        Console.WriteLine("Launching the feature...");
    }
}

public class Program5
{
    public static void Main()
    {
        Feature feature = new Feature();
        feature.LaunchFeature();

        //  Retrieve and print all bug reports using reflection
        MethodInfo method = typeof(Feature).GetMethod("LaunchFeature");
        var bugReports = method.GetCustomAttributes<BugReportAttribute>();

        Console.WriteLine("\nBug Reports:");
        foreach (var report in bugReports)
        {
            Console.WriteLine($"- Description: {report.Description}");
            Console.WriteLine($"  Reported By: {report.ReportedBy}");
            Console.WriteLine($"  Date: {report.Date}\n");
        }
    }
}



