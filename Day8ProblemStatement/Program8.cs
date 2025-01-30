
// 8. Compare Two Strings
// Problem:
// Write a C# program to compare two strings lexicographically (dictionary order) without
// using built-in compare methods.
// Example Input:
// String 1: "apple"
// String 2: "banana"
// Expected Output:
// "apple" comes before "banana" in lexicographical order
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        int minLength = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine($"{str1} comes before {str2}");
                return;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine($"{str2} comes before {str1}");
                return;
            }
        }

        if (str1.Length < str2.Length)
            Console.WriteLine($"{str1} comes before {str2}");
        else if (str1.Length > str2.Length)
            Console.WriteLine($"{str2} comes before {str1}");
        else
            Console.WriteLine("Both strings are equal.");
    }
}