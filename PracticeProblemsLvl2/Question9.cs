// 9. Basic Calculator:
// Write a program that performs basic mathematical operations (addition, subtraction,
// multiplication, division) based on user input.
// ● Each operation should be performed in its own function, and the program should
// prompt the user to choose which operation to perform.

using System;

class Question9
{
    public void BasicCalculator()
    {
        double a = GetInput("Enter the first number: ");
        double b = GetInput("Enter the second number: ");
        Console.WriteLine("Choose operation: 1. Addition 2. Subtraction 3. Multiplication 4. Division");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {Add(a, b)}");
                break;
            case 2:
                Console.WriteLine($"Result: {Subtract(a, b)}");
                break;
            case 3:
                Console.WriteLine($"Result: {Multiply(a, b)}");
                break;
            case 4:
                if (b != 0)
                    Console.WriteLine($"Result: {Divide(a, b)}");
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private double GetInput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    private double Add(double a, double b)
    {
        return a + b;
    }

    private double Subtract(double a, double b)
    {
        return a - b;
    }

    private double Multiply(double a, double b)
    {
        return a * b;
    }

    private double Divide(double a, double b)
    {
        return a / b;
    }
}





