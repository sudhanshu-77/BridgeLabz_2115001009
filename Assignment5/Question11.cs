// Question11.cs
using System;

class Question11
{
    public void FindMultiplesBelow100()
    {
        // Taking user input for a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Finding multiples below 100
        Console.WriteLine($"Multiples of {number} below 100 are:");
        for (int i = 1; i < 100; i++)
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
