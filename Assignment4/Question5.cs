using System;

class Question5
{
    public void CheckVotingEligibility()
    {
        // Taking user input for age
        Console.Write("Enter the age: ");
        int age = int.Parse(Console.ReadLine());

        // Checking voting eligibility
        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}

