using System;

class MainProgram
{
    static void Main(string[] args)
    {

       
        Problem1 problem1 = new Problem1();
        problem1.DisplayTimeZones();
        Console.ReadKey();

        Problem2 problem2 = new Problem2();
        problem2.DateArithmetic();
        Console.ReadKey();

        Problem3 problem3 = new Problem3();
        problem3.DisplayDateFormats();
        Console.ReadKey(); 

        Problem4 problem4 = new Problem4();
        problem4.CompareDates();
        Console.ReadKey(); 

        Console.WriteLine("All problems executed successfully.");
    }
}



