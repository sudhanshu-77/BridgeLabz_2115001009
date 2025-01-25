// Create a program to save odd and even numbers into odd and even arrays between 1 to the number entered by the user. Finally, print the odd and even numbers array
// Hint => 
// Get an integer input from the user, assign it to a variable number, and check for Natural Number. If not a natural number then print an error and exit the program
// Create an integer array for even and odd numbers with size = number / 2 + 1
// Create index variables for odd and even numbers and initialize them to zero
// Using a for loop, iterate from 1 to the number, and in each iteration of the loop, save the odd or even number into the corresponding array
// Finally, print the odd and even numbers array using the odd and even index


using System;

class Question7
{
    public void SaveOddEvenNumbers()
    {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Not a natural number.");
            return;
        }

        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        // Separate odd and even numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex++] = i;
            }
            else
            {
                oddNumbers[oddIndex++] = i;
            }
        }

        // Display odd numbers
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.WriteLine(oddNumbers[i]);
        }

        // Display even numbers
        Console.WriteLine("Even numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.WriteLine(evenNumbers[i]);
        }
    }
}

