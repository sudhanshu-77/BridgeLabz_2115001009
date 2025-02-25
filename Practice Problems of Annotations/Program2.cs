
// Exercise 2: Use Obsolete Attribute to Mark an Old Method
// Problem Statement: Create a class LegacyAPI with an old method OldFeature(), which should not be used anymore. Instead, introduce a new method NewFeature().
// Steps to Follow:
// Define a class LegacyAPI.
// Mark OldFeature() as [Obsolete].
// Call both methods and observe the warning.
using System;

public class LegacyAPI
{
   
    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature (deprecated).");
    }

 
    public void NewFeature()
    {
        Console.WriteLine("This is the new feature!");
    }
}

public class Program
{
    public static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        // Calling the old method (will show a warning)
        api.OldFeature();

       
        api.NewFeature();
    }
}



