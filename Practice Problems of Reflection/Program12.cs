// Method Execution Timing: Use Reflection to measure the execution time of methods in a given class dynamically.
using System;
using System.Diagnostics;
using System.Reflection;

public class TimedExecution
{
    public void QuickMethod()
    {
        for (int i = 0; i < 1000; i++) { }
    }

    public void SlowMethod()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

public class Program12
{
    public static void Main()
    {
        TimedExecution timed = new TimedExecution();
        Type type = typeof(TimedExecution);

        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke(timed, null);
            stopwatch.Stop();

            Console.WriteLine($"{method.Name} executed in: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}




