// Project Ideas Using C# Generics
// Smart Warehouse Management System
// Concepts: Generic Classes, Constraints, Variance
// Problem Statement: Develop a warehouse system that manages different types of items (Electronics, Groceries, Furniture).
// Hints: 
// Create an abstract class WarehouseItem that all items extend (Electronics, Groceries, Furniture).
// Implement a generic class Storage<T> where T : WarehouseItem to store items safely.
// Implement a method to display all items using List<T>.
using System;
using System.Collections.Generic;

// Abstract class representing a warehouse item
public abstract class WarehouseItem
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public WarehouseItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}

// Specific item classes
public class Electronics : WarehouseItem
{
    public Electronics(string name, decimal price) : base(name, price) { }
}

public class Groceries : WarehouseItem
{
    public Groceries(string name, decimal price) : base(name, price) { }
}

public class Furniture : WarehouseItem
{
    public Furniture(string name, decimal price) : base(name, price) { }
}

// Generic class for storage
public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        Console.WriteLine($"Items in storage ({typeof(T).Name}):");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    public static void Main()
    {
        var electronicsStorage = new Storage<Electronics>();
        var groceriesStorage = new Storage<Groceries>();
        var furnitureStorage = new Storage<Furniture>();

        while (true)
        {
            Console.WriteLine("\n1. Add Electronics Item");
            Console.WriteLine("2. Add Groceries Item");
            Console.WriteLine("3. Add Furniture Item");
            Console.WriteLine("4. Display All Items");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddItem<Electronics>(electronicsStorage);
                    break;

                case "2":
                    AddItem<Groceries>(groceriesStorage);
                    break;

                case "3":
                    AddItem<Furniture>(furnitureStorage);
                    break;

                case "4":
                    electronicsStorage.DisplayItems();
                    groceriesStorage.DisplayItems();
                    furnitureStorage.DisplayItems();
                    break;

                case "5":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void AddItem<T>(Storage<T> storage) where T : WarehouseItem, new()
    {
        Console.Write("Enter Item Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            T item = (T)Activator.CreateInstance(typeof(T), name, price);
            storage.AddItem(item);
            Console.WriteLine($"{typeof(T).Name} item added.");
        }
        else
        {
            Console.WriteLine("Invalid input for price. Please enter a valid number.");
        }
    }
}

