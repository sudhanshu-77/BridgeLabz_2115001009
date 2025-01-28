// 9.               Write a program to take user input for 5 numbers and check whether a number is positive or negative. Further for positive numbers check if the number is even or odd. Finally compare the first and last elements of the array and display if they are equal, greater, or less
// Hint => 
// a.               Write a Method to Check whether the number is positive or negative
// b.               Write a Method to check whether the number is even or odd
// c.                Write a Method to compare two numbers and return 1 if number1 > number2 or 0 if both are equal or -1 if number1 < number2 
// d.               In the main program, Loop through the array using the length call the method isPositive() and if positive call method isEven() and print accordingly 
// e.               If the number is negative, print negative. 
// f.                 Finally compare the first and last element of the array by calling the method compare() and display if they are equal, greater, or less

using System;

class Question9
{
    public void CheckNumberProperties()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check properties of each number
        foreach (int number in numbers)
        {
            if (IsPositive(number))
            {
                Console.WriteLine($"{number} is positive and {(IsEven(number) ? "even" : "odd")}.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
            }
        }

        // Compare the first and last elements of the array
        int comparison = Compare(numbers[0], numbers[^1]);
        if (comparison == 0)
        {
            Console.WriteLine("The first and last elements are equal.");
        }
        else if (comparison > 0)
        {
            Console.WriteLine("The first element is greater than the last element.");
        }
        else
        {
            Console.WriteLine("The first element is less than the last element.");
        }
    }

    private bool IsPositive(int number)
    {
        return number > 0;
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private int Compare(int number1, int number2)
    {
        if (number1 > number2)
            return 1;
        else if (number1 < number2)
            return -1;
        else
            return 0;
    }
}
