// 6. The University is charging the student a fee of INR 125000 for the course. The University is willing to offer a discount of 10%. Write a program to find the discounted amount and discounted price the student will pay for the course.
// Hint:
// Create a variable named fee and assign 125000 to it.
// Create another variable discountPercent and assign 10 to it.
// Compute discount and assign it to the discount variable.
// Compute and print the fee you have to pay by subtracting the discount from the fee.
// I/P => NONE
// O/P => The discount amount is INR _12500.00__ and final discounted fee is INR __112500.00_


using System;

class Question6
{
    public void UniversityFee()
    {
        // Define fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate discount and final fee
        double discount = fee * (discountPercent / 100);
        double finalFee = fee - discount;

        // Display the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
