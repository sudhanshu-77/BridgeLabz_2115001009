
// Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
// Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a program that performs Binary Search to find a target value in the matrix.

using System;

class Program13
{
    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int low = 0;
        int high = rows * cols - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return false;
    }

    static void Main()
    {
        int[,] matrix = {
            { 1, 3, 5 },
            { 7, 9, 11 },
            { 13, 15, 17 }
        };
        int target = 9;
        bool found = SearchMatrix(matrix, target);
        Console.WriteLine("Target found: " + found);
    }
}



