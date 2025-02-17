// Problem Statements
// StringBuilder Problem 1: Reverse a String Using StringBuilder
// Problem: Write a program that uses StringBuilder to reverse a given string. For example, if the input is "hello", the output should be "olleh".
using System;
using System.Text;

class Program1
{
    static string ReverseString(string input)
    {
        StringBuilder sb = new StringBuilder(input.Length);
        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }

    static void Main()
    {
        string input = "hello";
        string reversed = ReverseString(input);
        Console.WriteLine("Reversed string: " + reversed);
    }
}

