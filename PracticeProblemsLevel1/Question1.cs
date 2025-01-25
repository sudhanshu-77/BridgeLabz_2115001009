// Level 1 Practice Programs
// Write a program to take user input for the age of all 10 students in a class and check whether the student can vote depending on his/her age is greater or equal to 18.
// Hint => 
// Define an array of 10 integer elements and take user input for the student's age. 
// Loop through the array using the length property and for the element of the array check If the age is a negative number print an invalid age and if 18 or above, print The student with the age ___ can vote. Otherwise, print The student with the age ___ cannot vote. 

using System;

class Question1
{
    public void CheckVotingEligibility()
    {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age for student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Check voting eligibility for each student
        foreach (int age in ages)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"The student with the age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
}

