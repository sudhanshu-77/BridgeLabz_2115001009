using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            // Check if it's the start of a sequence
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                // Count consecutive numbers
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
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

        int longestSequenceLength = LongestConsecutiveSequence.FindLongestConsecutiveSequence(nums);

        Console.WriteLine("Length of the longest consecutive sequence: " + longestSequenceLength);
    }
}
