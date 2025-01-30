
// 11. Write a C# program that accepts two strings from the user and checks if the two
// strings are anagrams of each other (i.e., whether they contain the same characters in any
// order).
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first string:");
        string str1 = Console.ReadLine();
        Console.WriteLine("Enter the second string:");
        string str2 = Console.ReadLine();

        if (AreAnagrams(str1, str2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }

    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        int[] freq = new int[256]; // ASCII size

        foreach (char c in str1)
            freq[c]++;

        foreach (char c in str2)
            freq[c]--;

        foreach (int count in freq)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}
