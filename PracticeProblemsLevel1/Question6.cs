// Create a program to find the mean height of players present in a football team.
// Hint => 
// The formula to calculate the mean is: mean = sum of all elements / number of elements
// Create a double array named heights of size 11 and get input values from the user.
// Find the sum of all the elements present in the array.
// Divide the sum by 11 to find the mean height and print the mean height of the football team

using System;

class Question6
{
    public void CalculateMeanHeight()
    {
        double[] heights = new double[11];
        double sum = 0.0;

        // Get heights of players and calculate the sum
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height for player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }

        // Calculate and display the mean height
        double mean = sum / heights.Length;
        Console.WriteLine($"The mean height of the football team is {mean:F2}");
    }
}

