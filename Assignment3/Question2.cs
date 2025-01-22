// 2. Write an IntOperation program by taking a, b, and c as input values and print the following integer operations: a + b * c, a * b + c, c + a / b, and a % b + c. Please also understand the precedence of the operators.
// Hint:
// Create variables a, b, and c of int data type.
// Take user input for a, b, and c.
// Compute the 3 integer operations and assign results to variables.
// Finally, print the results and understand operator precedence.

// I/P => a, b, c
// O/P => The results of Int Operations are __648_, _771__,15  and __33_

using System;
class Question2
{
    public void PerformIntegerOperations()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        int c = int.Parse(Console.ReadLine());

        // Performing integer operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Displaying the results
        Console.WriteLine($"The results of Int Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
