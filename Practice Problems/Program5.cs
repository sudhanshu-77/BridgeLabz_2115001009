// Problem 1: Read a File Line by Line Using StreamReader
// Problem: Write a program that uses StreamReader to read a text file line by line and print each line to the console.

using System;
using System.IO;

class Program5
{
    static void Main()
    {
        string filePath = "example.txt";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}

