// Binary Search Problem 2: Find the Peak Element in an Array
// Problem: A peak element is an element that is greater than its neighbors. Write a program that performs Binary Search to find a peak element in an array.

using System;

class Program12
{
    static int FindPeakElement(int[] array)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (array[mid] > array[mid + 1])
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 1 };
        int peakIndex = FindPeakElement(array);
        Console.WriteLine("Peak element index: " + peakIndex);
    }
}



