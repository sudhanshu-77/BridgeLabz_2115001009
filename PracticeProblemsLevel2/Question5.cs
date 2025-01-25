// Create a program to take a number as input and reverse the number. To do this, store the digits of the number in an array and display the array in reverse order
// Hint => 
// Take user input for a number. 
// Find the count of digits in the number. 
// Find the digits in the number and save them in an array
// Create an array to store the elements of the digits array in reverse order
// Finally, display the elements of the array in reverse order  

using System;

class Question5
{
    public void ReverseNumber()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;

        // Store digits in array
        while (number != 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }

        // Display digits in reverse order
        Console.WriteLine("Reversed number:");
        for (int i = index - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}

