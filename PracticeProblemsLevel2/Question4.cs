// Rework the program 2, especially the Hint: if index equals maxDigit, we break from the loop. Here we want to modify to increase the size of the array i,e maxDigit by 10 if the index is equal to maxDigit. This is done to consider all digits to find the largest and second-largest number 
// Hint => 
// In Hint f inside the loop if the index is equal to maxDigit, increase maxDigit and make digits array to store more elements. 
// To do this, we need to create a new temp array of size maxDigit, copy from the current digits array the digits into the temp array, and assign the current digits array to the temp array
// Now the digits array will be able to store all digits of the number in the array and then find the largest and second largest number
using System;

class Question4
{
    public void FindLargendSecondLarge()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store digits in array
        while (number != 0)
        {
            if (index == maxDigit) 
            {
                // Increase array size by 10
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length); // Copy existing digits into temp
                digits = temp; // Reassign digits to the new array with more space
            }
            
            digits[index++] = number % 10; // Get last digit and store it in the array
            number /= 10; // Remove last digit from the number
        }

        // Find largest and second largest
        int largest = 0, secondLargest = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display results
        Console.WriteLine($"The largest digit is {largest}");
        Console.WriteLine($"The second largest digit is {secondLargest}");
    }
}

