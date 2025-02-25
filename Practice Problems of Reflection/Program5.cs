// 🔹 Intermediate Level
// Dynamic Method Invocation: Define a class MathOperations with multiple public methods (Add, Subtract, Multiply). Use Reflection to dynamically call any method based on user input. 
using System;
using System.Reflection;

public class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

public class Program5
{
    public static void Main()
    {
        MathOperations mathOps = new MathOperations();
        Type type = mathOps.GetType();

        Console.Write("Enter method name (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine("Method not found.");
            return;
        }

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = (int)method.Invoke(mathOps, new object[] { num1, num2 });
        Console.WriteLine($"Result: {result}");
    }
}

