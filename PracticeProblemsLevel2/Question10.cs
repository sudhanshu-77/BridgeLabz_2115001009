// Create a program to take a number as input find the frequency of each digit in the number using an array and display the frequency of each digit
// Hint => 
// Take the input for a number
// Find the count of digits in the number
// Find the digits in the number and save them in an array
// Find the frequency of each digit in the number. For this define a frequency array of size 10, Loop through the digits array, and increase the frequency of each digit
// Display the frequency of each digit in the number




using System;

class Question10
{
    public void FindDigitFrequency()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] frequency = new int[10];

        // Calculate frequency of each digit
        while (number != 0)
        {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        // Display frequency of each digit
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < frequency.Length; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}

