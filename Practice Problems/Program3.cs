// 3. Creating and Handling a Custom Exception
// 💡 Problem Statement:
// Create a custom exception called InvalidAgeException.
// Write a method ValidateAge(int age) that throws InvalidAgeException if the age is below 18.
// In Main(), take user input and call ValidateAge().
// If an exception occurs, display "Age must be 18 or above".
// Expected Behavior:
// If the age is >=18, print "Access granted!".
// If age <18, throw InvalidAgeException and display the message.
// using System;

// Custom exception class
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class AgeValidator
{
    // Method to validate age
    public static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above.");
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());

            ValidateAge(age);
            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number for age.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

