// Write a program to take user input for 5 numbers and check whether a number is positive,  negative, or zero. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they equal, greater or less
// Hint => 
// Define an integer array of 5 elements and get user input to store in the array.
// Loop through the array using the length If the number is positive, check for even or odd numbers and print accordingly
// If the number is negative, print negative. Else if the number is zero, print zero. 
// Finally compare the first and last element of the array and display if they equal, greater or less

using System;

class Question2
{
    public void CheckNumberProperties()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check properties of each number
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive and {(number % 2 == 0 ? "even" : "odd")}.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative.");
            }
            else
            {
                Console.WriteLine($"{number} is zero.");
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] == numbers[^1])
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (numbers[0] > numbers[^1])
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }
}

