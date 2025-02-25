// Intermediate Level
// 3️⃣ Create an Attribute for Logging Method Execution Time
// Problem Statement: Define an attribute LogExecutionTime to measure method execution time.
// Requirements:
// Apply LogExecutionTime to a method.
// Use Stopwatch before and after execution.
// Print execution time.
// Apply it to different methods and compare the time taken.
using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
}

public class ExecutionLogger
{
    public static void InvokeWithTiming(object obj, string methodName)
    {
        MethodInfo method = obj.GetType().GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        var attribute = method.GetCustomAttribute<LogExecutionTimeAttribute>();

        if (attribute != null)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(obj, null);
            stopwatch.Stop();

            Console.WriteLine($"Execution time for {method.Name}: {stopwatch.ElapsedMilliseconds} ms\n");
        }
        else
        {
            method.Invoke(obj, null);
        }
    }
}

public class TaskRunner
{
    [LogExecutionTime]
    public void FastTask()
    {
        Console.WriteLine("Running fast task...");
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        Console.WriteLine("Running slow task...");
        System.Threading.Thread.Sleep(1000);
    }
}

public class Program8
{
    public static void Main()
    {
        TaskRunner runner = new TaskRunner();

        ExecutionLogger.InvokeWithTiming(runner, "FastTask");
        ExecutionLogger.InvokeWithTiming(runner, "SlowTask");
    }
}



