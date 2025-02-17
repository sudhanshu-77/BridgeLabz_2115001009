// Linear Search Problem 1: Search for the First Negative Number
// Problem: You are given an integer array. Write a program that performs Linear Search to find the first negative number in the array.


using System;

class Program9
{
    static int FindFirstNegative(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                return i;
            }
        }
        return -1; // Return -1 if no negative number is found
    }

    static void Main()
    {
        int[] numbers = { 3, 5, -2, 8, -1 };
        int index = FindFirstNegative(numbers);
        Console.WriteLine("First negative number is at index: " + index);
    }
}

