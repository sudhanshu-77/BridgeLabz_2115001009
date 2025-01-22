// 4. Create a program to calculate the profit and loss in number and percentage based on the cost price of INR 129 and the selling price of INR 191.
// Hint:
// Use a single print statement to display multiline text and variables.
// Profit = selling price - cost price
// Profit Percentage = profit / cost price * 100
// I/P => NONE
// O/P =>
// The Cost Price is INR _129__ and Selling Price is INR 191___
// The Profit is INR __62_ and the Profit Percentage is _48.06%__

using System;

class Question4
{
    public void CalculateProfit()
    {
        // Create variables for cost price and selling price
        int costPrice = 129;
        int sellingPrice = 191;

        // Calculate profit and profit percentage
        int profit = sellingPrice - costPrice;
        double profitPercentage = (double)profit / costPrice * 100;

        // Display the result
        Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%");
    }
}
