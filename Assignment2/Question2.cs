// 2. Sam’s mark in Maths is 94, Physics is 95, and Chemistry is 96 out of 100. Find the average percent mark in PCM
// I/P => NONE
// O/P => Sam’s average mark in PCM is __95.00


using System;
class Question2
{
    public void CalculateAverage()
    {
        // Create integer variables for marks and assign values
        int maths = 94, physics = 95, chemistry = 96;

        // Calculate average of the marks
        double average = (maths + physics + chemistry) / 3.0;

        // Display the result
        Console.WriteLine($"Sam’s average mark in PCM is {average:F2}");
    }
}
