// 4. Handling Multiple Exceptions
// 💡 Problem Statement:
// Create a C# program that performs array operations.
// Accept an integer array and an index number.
// Retrieve and print the value at that index.
// Handle the following exceptions:
// IndexOutOfRangeException if the index is out of range.
// NullReferenceException if the array is null.
// Expected Behavior:
// If valid, print "Value at index X: Y".
// If the index is out of bounds, display "Invalid index!".
// If the array is null, display "Array is not initialized!".
using System;

class ArrayOperations
{
    public static void Main()
    {
        try
        {
             int[] array = null; 

            int index = 2; 

            // Check if the array is null
            if (array == null)
            {
                throw new NullReferenceException();
            }

            //retrieve the value at the specified index
            int value = array[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
    }
}

