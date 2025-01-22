// 3. Similarly, write the DoubleOpt program by taking double values and doing the same operations.
// I/P => a, b, c
// O/P => The results of Double Operations are __385_, __407_, 16.73913043478261  and _33__

using System;

class Question3
{
    public void PerformDoubleOperations()
    {
        // Taking user input for a, b, and c
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());

        // Performing double operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        // Displaying the results
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
