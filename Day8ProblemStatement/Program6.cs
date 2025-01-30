
// 6. Find Substring Occurrences
// Problem:
// Write a C# program to count how many times a given substring occurs in a string.
// using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();
        Console.WriteLine("Enter the substring:");
        string subString = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= mainString.Length - subString.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < subString.Length; j++)
            {
                if (mainString[i + j] != subString[j])
                {
                    match = false;
                    break;
                }
            }
            if (match) count++;
        }

        Console.WriteLine($"Occurrences of substring: {count}");
    }
}
