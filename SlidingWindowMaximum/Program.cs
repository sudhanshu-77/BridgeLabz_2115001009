// Sliding Window Maximum
// Problem: Given an array and a window size k, find the maximum element in each sliding window of size k.
// Hint: Use a deque (double-ended queue) to maintain indices of useful elements in each window.


using System;
using System.Collections.Generic;

public class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0) return new int[0];

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.First.Value];
            }
        }

        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;

        Console.WriteLine("Array: " + string.Join(", ", nums));
        Console.WriteLine("Window size: " + k);

        int[] maxValues = SlidingWindowMaximum.MaxSlidingWindow(nums, k);

        Console.WriteLine("Maximums in each sliding window: " + string.Join(", ", maxValues));
    }
}
