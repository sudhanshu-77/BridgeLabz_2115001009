// 7.               Write a program to generate a six-digit OTP number using Math.Random() method. Validate the numbers are unique by generating the OTP number 10 times and ensuring all the 10 OTPs are not the same
// Hint => 
// a.               Write a method to Generate a 6-digit OTP number using Math.Random() 
// b.               Create an array to save the OTP numbers generated 10 times
// c.                Write a method to ensure that the OTP numbers generated are unique. If unique return true else return false

using System;

class Question7
{
    public void GenerateUniqueOTPs()
    {
        int[] otps = new int[10];
        Random rand = new Random();

        // Generate 10 unique OTPs
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP(rand);
        }

        // Check for uniqueness
        bool areUnique = CheckUniqueness(otps);

        // Display results
        Console.WriteLine("Generated OTPs:");
        foreach (int otp in otps)
        {
            Console.WriteLine(otp);
        }
        Console.WriteLine($"Are all OTPs unique? {areUnique}");
    }

    private int GenerateOTP(Random rand)
    {
        return rand.Next(100000, 1000000); // Generate a 6-digit OTP
    }

    private bool CheckUniqueness(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false;
            }
        }
        return true;
    }
}
