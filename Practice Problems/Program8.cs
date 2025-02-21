// 8. Propagating Exceptions Across Methods
// 💡 Problem Statement:
// Create a C# program with three methods:
// Method1(): Throws an ArithmeticException (10 / 0).
// Method2(): Calls Method1().
// Main(): Calls Method2() and handles the exception.
// Expected Behavior:
// The exception propagates from Method1() → Method2() → Main().
// Catch and handle it in Main(), printing "Handled exception in Main".

using System;

class ExceptionPropagation
{
    static void Method1()
    {
        // throw an ArithmeticException due to division by zero
        int result = 10 / 0;
    }

    static void Method2()
    {
        // Call Method1, allowing any exceptions to propagate
        Method1();
    }

    static void Main()
    {
        try
        {
            // Call Method2, allowing exceptions to propagate to this point
            Method2();
        }
        catch (ArithmeticException ex)
        {
            // Handle the exception here
            Console.WriteLine("Handled exception in Main");
        }
    }

}
