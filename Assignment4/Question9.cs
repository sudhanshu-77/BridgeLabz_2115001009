using System;

class Question9
{
    public void CountdownForLoop()
    {
        // Taking user input for countdown start
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using for loop
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Rocket Launch!");
    }
}

