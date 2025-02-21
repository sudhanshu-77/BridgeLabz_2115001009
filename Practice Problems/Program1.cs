// Practice Problems for Exception Handling in C#
// 1. Handling File Not Found Exception
// 💡 Problem Statement:
// Create a C# program that reads a file named "data.txt". If the file does not exist, handle the IOException properly and display a user-friendly message.
// Expected Behavior:
// If the file exists, print its contents.
// If the file does not exist, catch the IOException and print "File not found".
using System;
using System.IO;

class FileNotFoundExceptionHandling
{
    public static void Main()
    {
        string filePath = "data.txt";

        try
        {
            // read the contents of the file
            string fileContents = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:");
            Console.WriteLine(fileContents);
        }
        catch (FileNotFoundException)
        {
          Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            // Handle other I/O exceptions
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

