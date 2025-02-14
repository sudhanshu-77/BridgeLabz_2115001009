
// Two Sum Problem
// Problem: Given an array and a target sum, find two indices such that their values add up to the target.
// Hint: Use a hash map to store the index of each element as you iterate. Check if target - current_element exists in the map.





using System;
using System.Collections.Generic;

public class TwoSumProblem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            // Check if the complement exists in the dictionary
            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            // Store the index of the current element
            if (!numToIndex.ContainsKey(nums[i]))
            {
                numToIndex[nums[i]] = i;
            }
        }

        throw new ArgumentException("No two sum solution exists.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] nums = Array.ConvertAll(inputArray, int.Parse);

        Console.WriteLine("Enter the target sum:");
        int target = int.Parse(Console.ReadLine());

        try
        {
            int[] result = TwoSumProblem.TwoSum(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
