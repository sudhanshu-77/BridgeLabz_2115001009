// Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array
// Hint => 
// Take user input for rows and columns, create a 2D array (Matrix), and take the user input 
// Copy the elements of the matrix to a 1D array. For this create a 1D array of size rows*columns as in int[] array = new int[rows * columns];
// Define the index variable and Loop through the 2D array. Copy every element of the 2D array into the 1D array and increment the index
// Note: For looping through the 2D array, you will need Nested for loop, Outer for loop for rows, and the inner for loops to access each element

using System;

class Question9
{
    public void Copy2DArrayTo1D()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int[] array = new int[rows * columns];
        int index = 0;

        // Get elements for the 2D array and copy to 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        // Display the 1D array
        Console.WriteLine("1D Array:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }
}

