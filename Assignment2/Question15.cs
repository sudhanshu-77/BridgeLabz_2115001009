// 15. Write a program to input the unit price of an item and the quantity to be bought. Then, calculate the total price.
// Hint: NA
// I/P => unitPrice, quantity
// O/P => The total purchase price is INR _1125.00__ if the quantity _15__ and unit price is INR _75.00__


using System;

class Question15
{
    public void PurchasePrice()
    {
        // Take user inputs for unit price and quantity
        Console.Write("Enter the unit price of the item: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the quantity of the item: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate total purchase price
        double totalPrice = unitPrice * quantity;

        // Display the result
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} for a quantity of {quantity} at a unit price of INR {unitPrice:F2}.");
    }
}
