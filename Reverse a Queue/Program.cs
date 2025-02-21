// 1. Reverse a Queue
// Reverse the elements of a queue using only queue operations.
// Example:
// Input: [10, 20, 30]
// Output: [30, 20, 10]
using System;
using System.Collections.Generic;

class ReverseQueue
{
    public static void Reverse(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;

        int item = queue.Dequeue();
        Reverse(queue);
        queue.Enqueue(item);
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });
        Reverse(queue);
        Console.WriteLine(string.Join(", ", queue)); // Output: 30, 20, 10
    }
}

