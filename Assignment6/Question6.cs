// Question6.cs
using System;

class Question6
{
    public void Calculator()
    {
        // Taking user input for two numbers and an operator
        Console.Write("Enter the first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        // Performing calculation based on the operator
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                if (second != 0)
                    Console.WriteLine($"Result: {first / second}");
                else
                    Console.WriteLine("Error: Division by zero");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
