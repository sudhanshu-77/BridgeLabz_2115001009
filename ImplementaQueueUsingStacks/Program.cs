using System;
using System.Collections.Generic;

public class QueueUsingStacks
{
    private Stack<int> stack1 = new Stack<int>();
    private Stack<int> stack2 = new Stack<int>();

    // Enqueue operation
    public void Enqueue(int item)
    {
        stack1.Push(item);
    }

    // Dequeue operation
    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return stack2.Pop();
    }

    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        QueueUsingStacks queue = new QueueUsingStacks();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); // Output: 1
        Console.WriteLine(queue.Dequeue()); // Output: 2

       
        queue.Enqueue(4);

        Console.WriteLine(queue.Dequeue()); // Output: 3
        Console.WriteLine(queue.Dequeue()); // Output: 4

        Console.WriteLine(queue.IsEmpty()); // Output: True
    }
}




