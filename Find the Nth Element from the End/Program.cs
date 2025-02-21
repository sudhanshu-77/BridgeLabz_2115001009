
// 5. Find the Nth Element from the End
// Given a singly linked list (LinkedList), find the Nth element from the end without calculating its size.
// Example:
// Input: [A, B, C, D, E], N=2
// Output: D
using System;
using System.Collections.Generic;

class NthElementFromEnd
{
    public static T FindNthFromEnd<T>(LinkedList<T> list, int n)
    {
        LinkedListNode<T> mainPtr = list.First;
        LinkedListNode<T> refPtr = list.First;

        int count = 0;
        while (count < n)
        {
            if (refPtr == null)
            {
                throw new ArgumentException("N is greater than the number of nodes in the list");
            }
            refPtr = refPtr.Next;
            count++;
        }

        while (refPtr != null)
        {
            mainPtr = mainPtr.Next;
            refPtr = refPtr.Next;
        }

        return mainPtr.Value;
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        string result = FindNthFromEnd(list, 2);
        Console.WriteLine(result);
    }
}

