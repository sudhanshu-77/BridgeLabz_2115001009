using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    // Method to check if there exists a pair with the given sum
    public static bool HasPairWithSum(int[] arr, int targetSum)
    {
        HashSet<int> visitedNumbers = new HashSet<int>();

        foreach (int number in arr)
        {
            int complement = targetSum - number;

            // Check if the complement exists in the set
            if (visitedNumbers.Contains(complement))
            {
                return true;
            }

            // Add the current number to the set
            visitedNumbers.Add(number);
        }

        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        int[] arr = Array.ConvertAll(inputArray, int.Parse);

        Console.WriteLine("Enter the target sum:");
        int targetSum = int.Parse(Console.ReadLine());

        bool result = PairWithGivenSum.HasPairWithSum(arr, targetSum);

        if (result)
        {
            Console.WriteLine("There exists a pair with the given sum.");
        }
        else
        {
            Console.WriteLine("No pair with the given sum exists.");
        }
    }
}
