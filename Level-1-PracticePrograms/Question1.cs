// Level 1 Practice Programs
// Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
// Hint => 
// Simple Interest = Principal * Rate * Time / 100
// Take user input for principal, rate, time
// Write a method to calculate the simple interest given principle, rate and time as parameters
// Output “The Simple Interest is ___ for Principal ___, Rate of Interest ___ and Time ___”


using System;

class Question1
{
    public void CalculateSimpleInterest()
    {
        // Taking user input for principal, rate, and time
        Console.Write("Enter the Principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the Rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the Time period in years: ");
        double time = double.Parse(Console.ReadLine());

        // Calculating simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Displaying the result
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, " +
            $"Rate of Interest {rate} and Time {time}");
    }
}
