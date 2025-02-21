// 2. Find Frequency of Elements
// Given a list of strings, count the frequency of each element and return the results in a Dictionary<string, int>.
// Example:
// Input: {"apple", "banana", "apple", "orange"}
// Output: { "apple": 2, "banana": 1, "orange": 1 }
using System;
using System.Collections.Generic;

class FrequencyCounter
{
    public static Dictionary<string, int> CountFrequency(List<string> list)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (var item in list)
        {
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }
        return frequency;
    }

    static void Main()
    {
        List<string> list = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> frequency = CountFrequency(list);
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

