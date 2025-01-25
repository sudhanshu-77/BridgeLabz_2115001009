// Create a program to find the youngest friends among 3 Amar, Akbar, and Anthony based on their ages and the tallest among the friends based on their heights
// Hint => 
// Take user input for age and height for the 3 friends and store it in two arrays each to store the values for age and height of the 3 friends
// Loop through the array and find the youngest of the 3 friends and the tallest of the 3 friends
// Finally display the youngest and tallest of the 3 friends


using System;

class Question2
{
    public void FindYoungestAndTallest()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        // Input ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write($"Enter height of {names[i]} in cm: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find youngest and tallest
        int youngestIndex = 0, tallestIndex = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
                youngestIndex = i;
            if (heights[i] > heights[tallestIndex])
                tallestIndex = i;
        }

        // Display results
        Console.WriteLine($"The youngest friend is {names[youngestIndex]}");
        Console.WriteLine($"The tallest friend is {names[tallestIndex]}");
    }
}

