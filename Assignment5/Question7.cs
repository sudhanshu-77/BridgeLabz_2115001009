// Question7.cs
using System;

class Question7
{
    public void FindYoungestAndTallest()
    {
        // Taking user input for ages and heights
        Console.Write("Enter age of Amar: ");
        int ageAmar = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Amar in cm: ");
        double heightAmar = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        int ageAkbar = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Akbar in cm: ");
        double heightAkbar = double.Parse(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        int ageAnthony = int.Parse(Console.ReadLine());
        Console.Write("Enter height of Anthony in cm: ");
        double heightAnthony = double.Parse(Console.ReadLine());

        // Finding the youngest
        string youngest = "Amar";
        int minAge = ageAmar;
        if (ageAkbar < minAge)
        {
            youngest = "Akbar";
            minAge = ageAkbar;
        }
        if (ageAnthony < minAge)
        {
            youngest = "Anthony";
        }

        // Finding the tallest
        string tallest = "Amar";
        double maxHeight = heightAmar;
        if (heightAkbar > maxHeight)
        {
            tallest = "Akbar";
            maxHeight = heightAkbar;
        }
        if (heightAnthony > maxHeight)
        {
            tallest = "Anthony";
        }

        // Displaying the results
        Console.WriteLine($"The youngest friend is {youngest}");
        Console.WriteLine($"The tallest friend is {tallest}");
    }
}
