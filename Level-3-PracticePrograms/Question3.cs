// 3.               Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
// Hint => 
// a.               Method to find the count of digits in the number and a Method to Store the digits of the number in a digits array
// b.               Method to find the sum of the digits of a number using the digits array
// c.                Method to find the sum of the squares of the digits of a number using the digits array. Use Math.Pow() method
// d.               Method to Check if a number is a Harshad number using a digits array. A number is called a Harshad number if it is divisible by the sum of its digits. For e.g. 21
// e.               Method to find the frequency of each digit in the number. Create a 2D array to store the frequency with digit in the first column and frequency in the second column.
using System;

class Question3
{
    public void NumberCheckerTasks2()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);
        int sumOfDigits = SumOfDigits(digits);
        int sumOfSquares = SumOfSquares(digits);
        bool isHarshad = IsHarshadNumber(number, sumOfDigits);
        int[,] digitFrequency = FindDigitFrequency(digits);

        // Display results
        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Sum of digits: {sumOfDigits}");
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");
        Console.WriteLine($"Is Harshad Number: {isHarshad}");
        Console.WriteLine("Digit frequencies:");
        for (int i = 0; i < digitFrequency.GetLength(0); i++)
        {
            Console.WriteLine($"Digit {digitFrequency[i, 0]}: {digitFrequency[i, 1]} times");
        }
    }

    private int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }

    private int[] StoreDigits(int number, int digitCount)
    {
        int[] digits = new int[digitCount];
        for (int i = digitCount - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    private int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    private int SumOfSquares(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, 2);
        }
        return sum;
    }

    private bool IsHarshadNumber(int number, int sumOfDigits)
    {
        return number % sumOfDigits == 0;
    }

    private int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
        }

        foreach (int digit in digits)
        {
            frequency[digit, 1]++;
        }

        return frequency;
    }
}
