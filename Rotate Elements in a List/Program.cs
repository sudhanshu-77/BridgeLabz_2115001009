// 3. Rotate Elements in a List
// Rotate the elements of a list by a given number of positions.
// Example:
// Input: [10, 20, 30, 40, 50], rotate by 2
// Output: [30, 40, 50, 10, 20]
using System;
using System.Collections.Generic;

class RotateList
{
    public static List<int> Rotate(List<int> list, int positions)
    {
        int count = list.Count;
        positions = positions % count;
        List<int> rotatedList = new List<int>(list.GetRange(positions, count - positions));
        rotatedList.AddRange(list.GetRange(0, positions));
        return rotatedList;
    }

    static void Main()
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        List<int> rotated = Rotate(list, 2);
        Console.WriteLine(string.Join(", ", rotated));
    }
}

