// 6. Online Food Delivery System
// Description: Create an online food delivery system:
// Define an abstract class FoodItem with fields like itemName, price, and quantity.
// Add abstract methods CalculateTotalPrice() and concrete methods like GetItemDetails().
// Extend it into classes VegItem and NonVegItem, overriding CalculateTotalPrice() to include additional charges.
// Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
// Use polymorphism to handle different types of food items dynamically.

using System;
using System.Collections.Generic;

// Abstract class representing a Food Item
abstract class FoodItem
{
    private string itemName;
    private double price;
    private int quantity;

    public string ItemName { get => itemName; set => itemName = value; }
    public double Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine($"Item Name: {ItemName}, Price: {Price}, Quantity: {Quantity}");
    }
}

// Interface for discountable items
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

// Veg item class
class VegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return Price * Quantity; //   total price calculation
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.1; //   discount calculation
    }

    public string GetDiscountDetails()
    {
        return "Discount: 10%";
    }
}

// Non-veg item class
class NonVegItem : FoodItem, IDiscountable
{
    public override double CalculateTotalPrice()
    {
        return Price * Quantity * 1.2; //   total price calculation
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05; //   discount calculation
    }

    public string GetDiscountDetails()
    {
        return "Discount: 5%";
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>();

        Console.Write("Enter the number of food items: ");
        int numberOfItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            Console.WriteLine($"Enter details for item {i + 1}:");
            Console.Write("Is the item Veg or Non-Veg? (Enter 'Veg' or 'NonVeg'): ");
            string itemType = Console.ReadLine();

            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (itemType.Equals("Veg", StringComparison.OrdinalIgnoreCase))
            {
                foodItems.Add(new VegItem { ItemName = itemName, Price = price, Quantity = quantity });
            }
            else if (itemType.Equals("NonVeg", StringComparison.OrdinalIgnoreCase))
            {
                foodItems.Add(new NonVegItem { ItemName = itemName, Price = price, Quantity = quantity });
            }
            else
            {
                Console.WriteLine("Invalid item type. Please enter 'Veg' or 'NonVeg'.");
                i--; // Decrement index to re-enter values
            }
        }

        // Process each food item and display details
        foreach (var item in foodItems)
        {
            item.GetItemDetails();
            Console.WriteLine($"Total Price: {item.CalculateTotalPrice()}");

            if (item is IDiscountable discountableItem)
            {
                Console.WriteLine($"Discount: {discountableItem.ApplyDiscount()}");
                Console.WriteLine(discountableItem.GetDiscountDetails());
            }
        }
    }
}
