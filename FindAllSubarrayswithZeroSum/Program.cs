using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static List<Tuple<int, int>> FindZeroSumSubarrays(int[] arr)
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumulativeSum = 0;

        sumMap[cumulativeSum] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++)
        {
            cumulativeSum += arr[i];

            if (sumMap.ContainsKey(cumulativeSum))
            {
                foreach (int startIndex in sumMap[cumulativeSum])
                {
                    result.Add(new Tuple<int, int>(startIndex + 1, i));
                }
            }

            if (!sumMap.ContainsKey(cumulativeSum))
            {
                sumMap[cumulativeSum] = new List<int>();
            }
            sumMap[cumulativeSum].Add(i);
        }

        return result;
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

        List<Tuple<int, int>> zeroSumSubarrays = ZeroSumSubarrays.FindZeroSumSubarrays(arr);

        Console.WriteLine("Subarrays with zero sum:");
        foreach (var subarray in zeroSumSubarrays)
        {
            Console.WriteLine($"Start: {subarray.Item1}, End: {subarray.Item2}");
        }
    }
}
