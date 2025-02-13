using System;
using System.Collections.Generic;

public class StackSorter
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();

            SortStack(stack);

            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
        }
        else
        {
            int temp = stack.Pop();

            InsertSorted(stack, element);

            stack.Push(temp);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        Console.WriteLine("Original Stack:");
        PrintStack(stack);

        StackSorter.SortStack(stack);

        Console.WriteLine("\nSorted Stack:");
        PrintStack(stack);
    }

    private static void PrintStack(Stack<int> stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
