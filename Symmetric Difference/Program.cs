// 3. Symmetric Difference
// Find the symmetric difference (elements present in either set but not both).
// Example:
// Input: {1, 2, 3}, {3, 4, 5}
// Output: {1, 2, 4, 5}
using System;
using System.Collections.Generic;

class SymmetricDifference
{
    public static HashSet<int> FindSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        symmetricDifference.SymmetricExceptWith(set2);
        return symmetricDifference;
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> result = FindSymmetricDifference(set1, set2);
        Console.WriteLine(string.Join(", ", result)); // Output: 1, 2, 4, 5
    }
}

