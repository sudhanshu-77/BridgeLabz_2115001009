// 6. Handling Invalid Input in Interest Calculation
// 💡 Problem Statement:
// Create a method CalculateInterest(double amount, double rate, int years) that:
// Throws ArgumentException if amount or rate is negative.
// Propagates the exception using throw and handles it in Main().
// Expected Behavior:
// If valid, return and print the calculated interest.
// If invalid, catch and display "Invalid input: Amount and rate must be positive".

using System;

class InterestCalculator
{
    public static double CalculateInterest(double amount, double rate, int years)
    {
        if (amount < 0 || rate < 0)
        {
            throw new ArgumentException("Amount and rate must be positive");
        }

        // Simple interest calculation
        return amount * rate * years / 100;
    }

    static void Main()
    {
        try
        {
            double amount = 1000; // amount
            double rate = 5; // rate
            int years = 3; // years

            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine($"Calculated Interest: {interest}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Invalid input: {ex.Message}");
        }
    }
}

