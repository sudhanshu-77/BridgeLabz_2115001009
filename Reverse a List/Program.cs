// 1. Reverse a List
// Write a program to reverse the elements of a given list without using built-in reverse methods. Implement it for both ArrayList and LinkedList.
// Example:
// Input: [1, 2, 3, 4, 5]
// Output: [5, 4, 3, 2, 1]
using System;
using System.Collections;

class ReverseArrayList
{
    public static ArrayList Reverse(ArrayList list)
    {
        ArrayList reversedList = new ArrayList();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            reversedList.Add(list[i]);
        }
        return reversedList;
    }

    static void Main()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        ArrayList reversed = Reverse(list);
        Console.WriteLine(string.Join(", ", reversed.ToArray()));
    }
}


// using System;
// using System.Collections.Generic;

// class ReverseLinkedList
// {
//     public static LinkedList<T> Reverse<T>(LinkedList<T> list)
//     {
//         LinkedList<T> reversedList = new LinkedList<T>();
//         foreach (var item in list)
//         {
//             reversedList.AddFirst(item);
//         }
//         return reversedList;
//     }

//     static void Main()
//     {
//         LinkedList<int> list = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
//         LinkedList<int> reversed = Reverse(list);
//         foreach (var item in reversed)
//         {
//             Console.Write(item + " ");
//         }
//     }
// }


