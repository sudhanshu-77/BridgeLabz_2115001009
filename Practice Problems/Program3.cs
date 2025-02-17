// Problem 1: Concatenate Strings Efficiently Using StringBuilder
// Problem: You are given an array of strings. Write a program that uses StringBuilder to concatenate all the strings in the array efficiently.
using System;
using System.Text;

class Program3
{
    static string ConcatenateStrings(string[] strings)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string str in strings)
        {
            sb.Append(str);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string[] strings = { "Hello", " ", "World", "!" };
        string result = ConcatenateStrings(strings);
        Console.WriteLine("Concatenated string: " + result);
    }
}



