// Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array
// Problem: You are given a rotated sorted array. Write a program that performs Binary Search to find the index of the smallest element in the array.


using System;

class Program11
{
    static int FindRotationPoint(int[] array)
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;
            if (array[mid] > array[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        return low;
    }

    static void Main()
    {
        int[] rotatedArray = { 4, 5, 6, 7, 0, 1, 2 };
        int rotationPoint = FindRotationPoint(rotatedArray);
        Console.WriteLine("Rotation point index: " + rotationPoint);
    }
}


