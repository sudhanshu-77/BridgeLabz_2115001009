// 2. E-Commerce Platform
// Description: Develop a simplified e-commerce platform:
// Create an abstract class Product with fields like productId, name, and price, and an abstract method CalculateDiscount().
// Extend it into concrete classes: Electronics, Clothing, and Groceries.
// Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for applicable product categories.
// Use encapsulation to protect product details, allowing updates only through setter methods.
// Showcase polymorphism by creating a method that calculates and prints the final price (price + tax - discount) for a list of products.
// using System;
// using System.Collections.Generic;

// Abstract class representing a Product
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId { get => productId; set => productId = value; }
    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value; }

    public abstract double CalculateDiscount();

    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product ID: {ProductId}, Name: {Name}, Price: {Price}");
    }
}

// Interface for taxable products
interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

// Electronics product class
class Electronics : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return Price * 0.1; //  discount calculation
    }

    public double CalculateTax()
    {
        return Price * 0.15; // tax calculation
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 15%";
    }
}

// Clothing product class
class Clothing : Product, ITaxable
{
    public override double CalculateDiscount()
    {
        return Price * 0.05; //  discount calculation
    }

    public double CalculateTax()
    {
        return Price * 0.08; //  tax calculation
    }

    public string GetTaxDetails()
    {
        return "Tax Rate: 8%";
    }
}

// Groceries product class
class Groceries : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.02; //  discount calculation
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of products
        List<Product> products = new List<Product>();

        // Take user input for products
        Console.WriteLine("Enter details for Electronics product:");
        products.Add(CreateProduct<Electronics>());

        Console.WriteLine("Enter details for Clothing product:");
        products.Add(CreateProduct<Clothing>());

        Console.WriteLine("Enter details for Groceries product:");
        products.Add(CreateProduct<Groceries>());

        // Process each product and display details
        foreach (var product in products)
        {
            product.DisplayProductDetails();
            Console.WriteLine($"Discount: {product.CalculateDiscount()}");

            if (product is ITaxable taxableProduct)
            {
                Console.WriteLine($"Tax: {taxableProduct.CalculateTax()}");
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }
        }
    }

    static T CreateProduct<T>() where T : Product, new()
    {
        T product = new T();

        Console.Write("Enter Product ID: ");
        product.ProductId = int.Parse(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        product.Name = Console.ReadLine();

        Console.Write("Enter Product Price: ");
        product.Price = double.Parse(Console.ReadLine());

        return product;
    }
}
