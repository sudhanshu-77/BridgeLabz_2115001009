//  Problem 2: Compare StringBuilder Performance
// Problem: Write a program that compares the performance of StringBuilder for concatenating strings multiple times.

using System;
using System.Diagnostics;
using System.Text;

class Program4
{
    static void Main()
    {
        int iterations = 10000;
        string baseString = "test";

        // Using StringBuilder
        Stopwatch sw = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append(baseString);
        }
        sw.Stop();
        Console.WriteLine("StringBuilder time: " + sw.ElapsedMilliseconds + "ms");

        // Using string concatenation
        sw.Restart();
        string result = string.Empty;
        for (int i = 0; i < iterations; i++)
        {
            result += baseString;
        }
        sw.Stop();
        Console.WriteLine("String concatenation time: " + sw.ElapsedMilliseconds + "ms");
    }
}

