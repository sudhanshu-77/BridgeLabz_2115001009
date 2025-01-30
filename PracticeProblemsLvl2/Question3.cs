
// 3. Prime Number Checker:
// Create a program that checks whether a given number is a prime number.
// ● The program should use a separate function to perform the prime check and return
// the result.

using System;

class Question3
{
    public void PrimeNumberChecker()
    {
        int number = GetInput("Enter a number to check if it's prime: ");
        bool isPrime = IsPrime(number);
        Console.WriteLine($"Is the number {number} a prime number? {isPrime}");
    }

    private int GetInput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    private bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}

