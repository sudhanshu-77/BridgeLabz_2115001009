// Exercise 3: Suppress Warnings for Unchecked Operations
// Problem Statement: Create an ArrayList without generics and use #pragma warning disables to hide compilation warnings.
using System;
using System.Collections;

public class Program3
{
    public static void Main()
    {
        // Suppress warnings for using non-generic collections
        #pragma warning disable CS8602

        ArrayList list = new ArrayList();
        list.Add("Hello");
        list.Add(42);
        list.Add(3.14);

        #pragma warning restore CS8602

        // Print the items in the list
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}



