// Binary Search for the target index:
// After sorting the array, perform binary search to find the index of the given target number.
// Return the index if found, otherwise return -1.
using System;

class Program16
{
    static int BinarySearch(int[] array, int target)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                return mid; // Target found
            }
            else if (array[mid] < target)
            {
                low = mid + 1; // Search in the right half
            }
            else
            {
                high = mid - 1; // Search in the left half
            }
        }

        return -1; // Target not found
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int target = 5;

        int index = BinarySearch(numbers, target);
        if (index != -1)
        {
            Console.WriteLine($"Target {target} found at index: {index}");
        }
        else
        {
            Console.WriteLine($"Target {target} not found in the array.");
        }
    }
}



