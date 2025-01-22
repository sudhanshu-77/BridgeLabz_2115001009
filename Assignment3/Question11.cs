// 11. Write a program to input the Principal, Rate, and Time values and calculate Simple Interest.
// Hint:
// Simple Interest = (Principal * Rate * Time) / 100
// I/P => principal, rate, time
// O/P => The Simple Interest is __13500_ for Principal _18000__, Rate of Interest __15 _ and Time _5__


using System;

class Question11
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
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}");
    }
}
