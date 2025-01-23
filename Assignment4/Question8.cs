using System;

class Question8
{
    public void CountdownWhileLoop()
    {
        // Taking user input for countdown start
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // Countdown using while loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("Rocket Launch!");
    }
}

