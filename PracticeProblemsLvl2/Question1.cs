// Problem Statements for Practice in C#
// 1. Number Guessing Game:
// Write a program where the user thinks of a number between 1 and 100, and the computer
// tries to guess the number by generating random guesses.
// ● The user provides feedback by indicating whether the guess is high, low, or correct.
// ● The program should be modular, with different functions for generating guesses,
// receiving user feedback, and determining the next guess.

using System;

class Question1
{
    public void NumberGuessingGame()
    {
        int low = 1, high = 100;
        Random random = new Random();
        bool correct = false;

        Console.WriteLine("Think of a number between 1 and 100.");

        while (!correct)
        {
            int guess = random.Next(low, high + 1);
            Console.WriteLine($"Is your number {guess}? (Enter 'high', 'low', or 'correct')");
            string feedback = Console.ReadLine().ToLower();

            if (feedback == "high")
            {
                high = guess - 1;
            }
            else if (feedback == "low")
            {
                low = guess + 1;
            }
            else if (feedback == "correct")
            {
                correct = true;
                Console.WriteLine("The computer guessed your number!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'high', 'low', or 'correct'.");
            }
        }
    }
}

