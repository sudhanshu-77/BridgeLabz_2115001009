
// 2. Union and Intersection of Two Sets
// Compute the union and intersection of two sets.
// Example:
// Set1: {1, 2, 3}, Set2: {3, 4, 5}
// Output:
// Union: {1, 2, 3, 4, 5}
// Intersection: {3}
using System;
using System.Collections.Generic;

class SetOperations
{
    public static (HashSet<int> union, HashSet<int> intersection) UnionAndIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);

        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);

        return (union, intersection);
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        var (union, intersection) = UnionAndIntersection(set1, set2);
        Console.WriteLine("Union: " + string.Join(", ", union)); // Output: Union: 1, 2, 3, 4, 5
        Console.WriteLine("Intersection: " + string.Join(", ", intersection)); // Output: Intersection: 3
    }
}

