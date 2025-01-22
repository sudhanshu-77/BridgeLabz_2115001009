
// 9. Write a new program similar to the program # 6 but take user input for Student Fee and University Discount
// Hint:
// Create a variable named fee and take user input for fee.
// Create another variable discountPercent and take user input.
// Compute the discount and assign it to the discount variable.
// Compute and print the fee you have to pay by subtracting the discount from the fee.
// I/P => fee, discountPrecent
// O/P => The discount amount is INR _60.00__ and final discounted fee is INR 1140.00___


using System;

class Question9
{
    public void DiscountWithInput()
    {
        // Take user input for fee and discount percentage
        Console.Write("Enter the student fee: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate discount and final fee
        double discount = fee * (discountPercent / 100);
        double finalFee = fee - discount;

        // Display the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
