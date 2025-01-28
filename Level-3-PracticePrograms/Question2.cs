 
// 2.               Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
// Hint => 
// a.               Method to Find the count of digits in the number
// b.               Method to Store the digits of the number in a digits array
// c.                Method to Check if a number is a duck number using the digits array. A duck number is a number that has a non-zero digit present in it
// d.               Method to check if the number is an armstrong number using the digits array. ​​Armstrong number is a number that is equal to the sum of its own digits raised to the power of the number of digits. Eg: 153 = 1^3 + 5^3 + 3^3
// e.               Method to find the largest and second largest elements in the digits array. Use Int32.MinValue to initialize the variable.
// f.                 Method to find the smallest and second smallest elements in the digits array. Use Int32.MaxValue to initialize the variable.

using System;

class Question2
{
    public void NumberCheckerTasks()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        int digitCount = CountDigits(number);
        int[] digits = StoreDigits(number, digitCount);
        bool isDuck = IsDuckNumber(digits);
        bool isArmstrong = IsArmstrongNumber(digits, digitCount);
        (int largest, int secondLargest) = FindLargestAndSecondLargest(digits);
        (int smallest, int secondSmallest) = FindSmallestAndSecondSmallest(digits);

        // Display results
        Console.WriteLine($"Digit count: {digitCount}");
        Console.WriteLine($"Is Duck Number: {isDuck}");
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");
        Console.WriteLine($"Largest digit: {largest}, Second largest digit: {secondLargest}");
        Console.WriteLine($"Smallest digit: {smallest}, Second smallest digit: {secondSmallest}");
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

    private bool IsDuckNumber(int[] digits)
    {
        foreach (int digit in digits)
        {
            if (digit == 0)
                return true;
        }
        return false;
    }

    private bool IsArmstrongNumber(int[] digits, int digitCount)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, digitCount);
        }
        return sum == digits[0] * (int)Math.Pow(10, digitCount - 1) + digits[1] * (int)Math.Pow(10, digitCount - 2) + digits[2];
    }

    private (int, int) FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue, secondLargest = Int32.MinValue;
        foreach (int digit in digits)
        {
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest)
            {
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }

    private (int, int) FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue, secondSmallest = Int32.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < smallest)
            {
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest)
            {
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
}
