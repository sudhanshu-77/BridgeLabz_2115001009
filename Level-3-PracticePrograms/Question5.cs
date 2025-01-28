// 5.               Extend or Create a NumberChecker utility class and perform the following task. Call from the main() method the different methods and display results. Make sure all are static methods
// Hint => 
// a.               Method to Check if a number is a prime number. A prime number is a number greater than 1 that has no positive divisors other than 1 and itself. 
// b.               Method to Check if a number is a neon number. A neon number is a number where the sum of digits of the square of the number is equal to the number itself 
// c.                Method to Check if a number is a spy number. A number is called a spy number if the sum of its digits is equal to the product of its digits
// d.               Method to Check if a number is an automorphic number. An automorphic number is a number whose square ends with the number itself. E.g. 5 is an automorphic number
// e.               Method to Check if a number is a buzz number. A buzz number is a number that is either divisible by 7 or ends with 7

using System;

class Question5
{
    public void NumberCheckerTasks4()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Perform various number checks
        bool isPrime = IsPrimeNumber(number);
        bool isNeon = IsNeonNumber(number);
        bool isSpy = IsSpyNumber(number);
        bool isAutomorphic = IsAutomorphicNumber(number);
        bool isBuzz = IsBuzzNumber(number);

        // Display results
        Console.WriteLine($"Is Prime Number: {isPrime}");
        Console.WriteLine($"Is Neon Number: {isNeon}");
        Console.WriteLine($"Is Spy Number: {isSpy}");
        Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");
        Console.WriteLine($"Is Buzz Number: {isBuzz}");
    }

    private bool IsPrimeNumber(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    private bool IsNeonNumber(int number)
    {
        int square = number * number;
        int sumOfDigits = 0;
        while (square != 0)
        {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    private bool IsSpyNumber(int number)
    {
        int sum = 0, product = 1;
        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    private bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        return square % (int)Math.Pow(10, number.ToString().Length) == number;
    }

    private bool IsBuzzNumber(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
}
