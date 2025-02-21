// 5. Find Subsets
// Check if one set is a subset of another.
// Example:
// Input: {2, 3}, {1, 2, 3, 4}
// Output: true
using System;
using System.Collections.Generic;

class SubsetCheck
{
    public static bool IsSubset(HashSet<int> subset, HashSet<int> set)
    {
        return set.IsSupersetOf(subset);
    }

    static void Main()
    {
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> set = new HashSet<int> { 1, 2, 3, 4 };
        Console.WriteLine(IsSubset(subset, set)); // Output: true
    }
}

