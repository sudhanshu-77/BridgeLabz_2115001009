
// Problem:
// You are given a list of integers. Write a program that uses Linear Search to find the first missing positive integer in the list and Binary Search to find the index of a given target number.
// Approach:
// Linear Search for the first missing positive integer:
// Iterate through the list and mark each number in the list as visited (you can use negative marking or a separate array).
// Traverse the array again to find the first positive integer that is not marked.

using System;
using System.Collections.Generic;

class Program15
{
    static int FindFirstMissingPositive(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        int i = 1;
        while (set.Contains(i))
        {
            i++;
        }
        return i;
    }

    static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] numbers = { 3, 4, -1, 1 };
        int missingPositive = FindFirstMissingPositive(numbers);
        Console.WriteLine("First missing positive: " + missingPositive);

        Array.Sort(numbers);
        int target = 4;
        int index = BinarySearch(numbers, target);
        Console.WriteLine("Index of target: " + index);
    }
}

