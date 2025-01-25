// Create a program to find the multiplication table of a number entered by the user from 6 to 9 and display the result
// Hint => 
// Take integer input and store it in the variable number as well as define an integer array to store the multiplication result in the variable multiplicationResult
// Using a for loop, find the multiplication table of numbers from 6 to 9 and save the result in the array
// Finally, display the result from the array in the format number * i = ___

using System;

class Question5
{
    public void MultiplicationTableRange()
    {
        Console.Write("Enter a number for the multiplication table: ");
        int number = int.Parse(Console.ReadLine());
        int[] multiplicationResult = new int[4];

        // Calculate multiplication table from 6 to 9
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            multiplicationResult[i] = number * (i + 6);
        }

        // Display the multiplication table
        for (int i = 0; i < multiplicationResult.Length; i++)
        {
            Console.WriteLine($"{number} * {i + 6} = {multiplicationResult[i]}");
        }
    }
}

