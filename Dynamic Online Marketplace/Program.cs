// Dynamic Online Marketplace
// Concepts: Type Parameters, Generic Methods, Constraints
// Problem Statement: Build a generic product catalog for an online marketplace supporting various product types.
// Hints: 
// Define a generic class Product<T> where T is restricted to a category (BookCategory, ClothingCategory).
// Implement a generic method void ApplyDiscount<T>(T product, double percentage) where T : Product.
// Ensure type safety while allowing multiple product categories in the catalog.
using System;
using System.Collections.Generic;

// Category classes
public abstract class Category
{
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }
}

public class BookCategory : Category
{
    public BookCategory() : base("Books") { }
}

public class ClothingCategory : Category
{
    public ClothingCategory() : base("Clothing") { }
}

// Generic Product class
public class Product<T> where T : Category
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public T Category { get; set; }

    public Product(string productName, decimal price, T category)
    {
        ProductName = productName;
        Price = price;
        Category = category;
    }

    public override string ToString()
    {
        return $"{ProductName} - ${Price} ({Category.Name})";
    }
}

// Marketplace class
public class Marketplace
{
    private List<object> products = new List<object>();

    public void AddProduct<T>(Product<T> product) where T : Category
    {
        products.Add(product);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Product Catalog:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public void ApplyDiscount<T>(Product<T> product, double percentage) where T : Category
    {
        if (percentage < 0 || percentage > 100)
        {
            throw new ArgumentException("Percentage must be between 0 and 100.");
        }

        product.Price -= product.Price * (decimal)(percentage / 100);
    }
}

public class Program
{
    public static void Main()
    {
        var marketplace = new Marketplace();

        while (true)
        {
            Console.WriteLine("\n1. Add Book Product");
            Console.WriteLine("2. Add Clothing Product");
            Console.WriteLine("3. Display Products");
            Console.WriteLine("4. Apply Discount");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddProduct<BookCategory>(marketplace);
                    break;

                case "2":
                    AddProduct<ClothingCategory>(marketplace);
                    break;

                case "3":
                    marketplace.DisplayProducts();
                    break;

                case "4":
                    ApplyDiscount(marketplace);
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

    static void AddProduct<T>(Marketplace marketplace) where T : Category, new()
    {
        Console.Write("Enter Product Name: ");
        string productName = Console.ReadLine();
        Console.Write("Enter Price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            T category = new T();
            Product<T> product = new Product<T>(productName, price, category);
            marketplace.AddProduct(product);
            Console.WriteLine($"{typeof(T).Name} product added.");
        }
        else
        {
            Console.WriteLine("Invalid input for price. Please enter a valid number.");
        }
    }

    static void ApplyDiscount(Marketplace marketplace)
    {
        Console.Write("Enter Product Name to Apply Discount: ");
        string productName = Console.ReadLine();
        Console.Write("Enter Discount Percentage: ");
        if (double.TryParse(Console.ReadLine(), out double percentage))
        {
            foreach (var item in marketplace.Products)
            {
                if (item is Product<Category> product && product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    marketplace.ApplyDiscount(product, percentage);
                    Console.WriteLine($"Discount applied to {productName}.");
                    return;
                }
            }
            Console.WriteLine("Product not found.");
        }
        else
        {
            Console.WriteLine("Invalid input for percentage. Please enter a valid number.");
        }
    }
}

