// Create a program to print a multiplication table of a number.
// Hint => 
// Get an integer input and store it in the number variable. Also, define a integer array to store the results of multiplication from 1 to 10
// Run a loop from 1 to 10 and store the results in the multiplication table array
// Finally, display the result from the array in the format number * i = __

using System;

class Question3
{
    public void MultiplicationTable()
    {
        Console.Write("Enter a number for the multiplication table: ");
        int number = int.Parse(Console.ReadLine());
        int[] table = new int[10];

        // Calculate multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = number * (i + 1);
        }

        // Display the multiplication table
        for (int i = 0; i < table.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {table[i]}");
        }
    }
}

