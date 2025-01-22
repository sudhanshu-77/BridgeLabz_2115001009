// 7. Write a Program to compute the volume of Earth in km^3 and miles^3
// Hint: Volume of a Sphere is (4/3) * pi * r^3 and radius of earth is 6378 km
// O/P => The volume of earth in cubic kilometers is _1086781292542.89___ and cubic miles is __260732455872.69__


using System;

class Question7
{
    public void EarthVolume()
    {
        // Define radius of earth in km and conversion factor to miles
        double radiusKm = 6378;
        double kmToMiles = 0.621371;

        // Calculate volume in cubic kilometers and miles
        double volumeKm = (4.0 / 3) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles = volumeKm * Math.Pow(kmToMiles, 3);

        // Display the result
        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm:F2} and cubic miles is {volumeMiles:F2}");
    }
}
