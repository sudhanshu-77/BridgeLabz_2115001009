//  Problem 2: Read User Input and Write to File Using StreamReader
// Problem: Write a program that reads user input from the console and writes it to a file.


using System;
using System.IO;

class Program8
{
    static void Main()
    {
        string filePath = "output.txt";
        Console.WriteLine("Enter text to write to file (type 'exit' to finish):");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                writer.WriteLine(input);
            }
        }
    }
}

