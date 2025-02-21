// 4. Convert a Set to a Sorted List
// Convert a HashSet<int> into a sorted list in ascending order.
// Example:
// Input: {5, 3, 9, 1}
// Output: [1, 3, 5, 9]
using System;
using System.Collections.Generic;

class SetToSortedList
{
    public static List<int> ConvertToSortedList(HashSet<int> set)
    {
        List<int> sortedList = new List<int>(set);
        sortedList.Sort();
        return sortedList;
    }

    static void Main()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedList = ConvertToSortedList(set);
        Console.WriteLine(string.Join(", ", sortedList)); // Output: 1, 3, 5, 9
    }
}

