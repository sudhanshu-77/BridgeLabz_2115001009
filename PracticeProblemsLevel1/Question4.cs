// Write a program to store multiple values in an array up to a maximum of 10 or until the user enters a 0 or a negative number. Show all the numbers as well as the sum of all numbers 
// Hint => 
// Create a variable to store an array of 10 elements of type double as well as a variable to store the total of type double initializes to 0.0. Also, the index variable is initialized to 0 for the array
// Use infinite while loop as in while (true)
// Take the user entry and check if the user entered 0 or a negative number to break the loop 
// Also, break from the loop if the index has a value of 10 as the array size is limited to 10.
// If the user entered a number other than 0 or a negative number inside the while loop then assign the number to the array element and increment the index value
// Take another for loop to get the values of each element and add it to the total 
// Finally display the total value

using System;

class Question4
{
    public void StoreValuesInArray()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Store values in the array until 0 or negative is entered
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10)
            {
                break;
            }

            numbers[index++] = input;
        }

        // Calculate the sum of the stored values
        for (int i = 0; i < index; i++)
        {
            total += numbers[i];
        }

        // Display the total sum
        Console.WriteLine($"The total sum is {total}");
    }
}



