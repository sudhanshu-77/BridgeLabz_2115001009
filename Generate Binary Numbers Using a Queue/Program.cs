
// 2. Generate Binary Numbers Using a Queue
// Generate the first N binary numbers using a queue.
// Example:
// Input: N=5
// Output: {"1", "10", "11", "100", "101"}
using System;
using System.Collections.Generic;

class BinaryNumbersGenerator
{
    public static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return result;
    }

    static void Main()
    {
        int n = 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(n);
        Console.WriteLine(string.Join(", ", binaryNumbers)); // Output: 1, 10, 11, 100, 101
    }
}

