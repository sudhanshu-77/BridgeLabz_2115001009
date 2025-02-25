
// 7️⃣ Implement a Custom Caching System with CacheResult
// Problem Statement: Define CacheResult to store method return values and avoid repeated execution.
// Requirements:
// Apply CacheResult to a computationally expensive method.
// Implement a cache (Dictionary) to store previously computed results.
// If a method is called with the same input, return the cached result instead of recomputation.



using System;
using System.Collections.Generic;
using System.Reflection;

//  custom attribute CacheResult
[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
}

//  class to manage caching
public static class CacheManager
{
    private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

    public static object GetOrAdd(string key, Func<object> compute)
    {
        if (Cache.TryGetValue(key, out var cachedValue))
        {
            Console.WriteLine("Returning cached result.");
            return cachedValue;
        }

        var result = compute();
        Cache[key] = result;
        return result;
    }
}

//  class with a computationally expensive method
public class ExpensiveComputation
{
    [CacheResult]
    public int ComputeFactorial(int n)
    {
        return (int)CacheManager.GetOrAdd($"Factorial_{n}", () => Factorial(n));
    }

    private int Factorial(int n)
    {
        Console.WriteLine($"Computing factorial of {n}...");
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }
}

public class Program12
{
    public static void Main()
    {
        ExpensiveComputation computation = new ExpensiveComputation();

        // First call will compute and cache the result
        Console.WriteLine(computation.ComputeFactorial(5));

        // Second call with the same input will return the cached result
        Console.WriteLine(computation.ComputeFactorial(5));
    }
}





