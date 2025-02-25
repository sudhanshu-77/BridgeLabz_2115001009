
// Invoke Private Method: Define a class Calculator with a private method Multiply(int a, int b). Use Reflection to invoke this method and display the result. 
using System;
using System.Reflection;

public class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program3
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo multiplyMethod = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (multiplyMethod != null)
        {
            object result = multiplyMethod.Invoke(calc, new object[] { 3, 5 });
            Console.WriteLine("Result of Multiply(3, 5): " + result);
        }
    }
}

