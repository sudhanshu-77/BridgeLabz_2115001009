
// Problem 1: Convert Byte Stream to Character Stream Using StreamReader
// Problem: Write a program that uses StreamReader to read binary data from a file and print it as characters.

using System;
using System.IO;
using System.Text;

class Program7
{
    static void Main()
    {
        string filePath = "binaryfile.dat";
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}



