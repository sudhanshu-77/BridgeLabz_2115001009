// 4. Remove Duplicates While Preserving Order
// Remove duplicate elements from a list while maintaining the original order.
// Example:
// Input: [3, 1, 2, 2, 3, 4]
// Output: [3, 1, 2, 4]
using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    public static List<int> RemoveDuplicatesPreserveOrder(List<int> list)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (var item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }
        return result;
    }

    static void Main()
    {
        List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> result = RemoveDuplicatesPreserveOrder(list);
        Console.WriteLine(string.Join(", ", result));
    }
}

