// 8.Write a program to find the smallest and the largest of the 3 numbers.
// Hint => 
// Take user input for 3 numbers
// Write a single method to find the smallest and largest of the three numbers
// public static int[] FindSmallestAndLargest(int number1, int number2, int number3)

using System;

class Question8
{
    public void FindRemainderAndQuotient()
    {
        // Taking user input for two numbers
        Console.Write("Enter the dividend: ");
        int dividend = int.Parse(Console.ReadLine());
        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;

        // Displaying the results
        Console.WriteLine($"The quotient is {quotient} and the remainder is {remainder}");
    }
}
