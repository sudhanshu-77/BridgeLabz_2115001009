// 7. Create a program to swap two numbers
// Hint:
// Create a variable number1 and take user input.
// Create a variable number2 and take user input.
// Swap number1 and number2 and print the swapped output.
// I/P => number1, number2
// O/P => The swapped numbers are _67__ and _28__


using System;

class Question7
{
    public void SwapNumbers()
    {
        // Taking user input for two numbers
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Swapping numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Displaying the swapped numbers
        Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
}
