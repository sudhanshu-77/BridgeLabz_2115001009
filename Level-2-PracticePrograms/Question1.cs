// Level 2 Practice Programs
// 1.Create a program to find the factors of a number taken as user input, store the factors in an array and display the factors. Also find the sum, sum of square of factors and product of the factors and display the results
// Hint => 
// Take the input for a number
// Write a static Method to find the factors of the number and save them in an array and return the array. 
// To find factors and save to array will have two loops. The first loop to find the count and initialize the array with the count. And the second loop save the factors into the array
// Write a method to find the sum of the factors using factors array
// Write a method to find the product of the factors using factors array
// Write a method to find the sum of square of the factors using Math.Pow() method

using System;
using System.Collections.Generic;

class Question1
{
    public void FindFactors()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Find factors and store in an array
        int[] factors = GetFactors(number);

        // Calculate sum, sum of squares, and product of factors
        int sum = CalculateSum(factors);
        int sumOfSquares = CalculateSumOfSquares(factors);
        int product = CalculateProduct(factors);

        // Display results
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine($"Sum of factors: {sum}");
        Console.WriteLine($"Sum of squares of factors: {sumOfSquares}");
        Console.WriteLine($"Product of factors: {product}");
    }

    private int[] GetFactors(int number)
    {
        List<int> factorList = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factorList.Add(i);
            }
        }
        return factorList.ToArray();
    }

    private int CalculateSum(int[] factors)
    {
        int sum = 0;
        foreach (int factor in factors)
        {
            sum += factor;
        }
        return sum;
    }

    private int CalculateSumOfSquares(int[] factors)
    {
        int sumOfSquares = 0;
        foreach (int factor in factors)
        {
            sumOfSquares += (int)Math.Pow(factor, 2);
        }
        return sumOfSquares;
    }

    private int CalculateProduct(int[] factors)
    {
        int product = 1;
        foreach (int factor in factors)
        {
            product *= factor;
        }
        return product;
    }
}
