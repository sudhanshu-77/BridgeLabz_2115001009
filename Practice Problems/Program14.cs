
// Binary Search Problem 4: Find the First and Last Occurrence of an Element in a Sorted Array
// Problem: Given a sorted array and a target element, write a program that uses Binary Search to find the first and last occurrence of the target element in the array.

using System;


class Program14
{
    static int[] FindFirstAndLast(int[] array, int target)
    {
        int first = FindBound(array, target, true);
        int last = FindBound(array, target, false);
        return new int[] { first, last };
    }

    static int FindBound(int[] array, int target, bool isFirst)
    {
        int low = 0;
        int high = array.Length - 1;
        int bound = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (array[mid] == target)
            {
                bound = mid;
                if (isFirst)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
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
        return bound;
    }

    static void Main()
    {
        int[] sortedArray = { 5, 7, 7, 8, 8, 10 };
        int target = 8;
        int[] result = FindFirstAndLast(sortedArray, target);
        Console.WriteLine("First and last occurrence: " + string.Join(", ", result));
    }
}

