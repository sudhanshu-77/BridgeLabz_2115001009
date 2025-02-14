// Circular Tour Problem
// Problem: Given a set of petrol pumps with petrol and distance to the next pump, determine the starting point for completing a circular tour.
// Hint: Use a queue to simulate the tour, keeping track of surplus petrol at each pump.


using System;
using System.Collections.Generic;

public class PetrolPump
{
    public int Petrol { get; set; }
    public int Distance { get; set; }
}

public class CircularTour
{
    public static int FindStartingPoint(PetrolPump[] pumps)
    {
        int n = pumps.Length;
        int start = 0;
        int end = 1;
        int currentPetrol = pumps[start].Petrol - pumps[start].Distance;

        while (end != start || currentPetrol < 0)
        {
            while (currentPetrol < 0 && start != end)
            {
                currentPetrol -= pumps[start].Petrol - pumps[start].Distance;
                start = (start + 1) % n;

                if (start == 0)
                {
                    return -1;
                }
            }

            currentPetrol += pumps[end].Petrol - pumps[end].Distance;
            end = (end + 1) % n;
        }

        return start;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PetrolPump[] pumps = new PetrolPump[]
        {
            new PetrolPump { Petrol = 4, Distance = 6 },
            new PetrolPump { Petrol = 6, Distance = 5 },
            new PetrolPump { Petrol = 7, Distance = 3 },
            new PetrolPump { Petrol = 4, Distance = 5 }
        };

        int startingPoint = CircularTour.FindStartingPoint(pumps);

        if (startingPoint != -1)
        {
            Console.WriteLine("starting point for the circular tour is pump index: " + startingPoint);
        }
        else
        {
            Console.WriteLine("No solution exists ");
        }
    }
}
