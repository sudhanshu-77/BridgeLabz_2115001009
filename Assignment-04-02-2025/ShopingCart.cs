// Sample Program 4: Shopping Cart System
// Create a Product class to manage shopping cart items with the following features:
// static: 
// A static variable Discount shared by all products.
// A static method UpdateDiscount() to modify the discount percentage.
// this: 
// Use this to initialize ProductName, Price, and Quantity in the constructor.
// readonly: 
// Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
// is operator: 
// Validate whether an object is an instance of the Product class before processing its details.
// using System;

using System;

class ShoppingCart
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Discount");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Product Name");
                    string productName = Console.ReadLine();

                    Console.WriteLine("Enter Price");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Product product = new Product(productName, price, quantity);

                    if (product is Product)
                    {
                        product.DisplayDetails();
                    }
                    break;

                case 2:
                    Console.WriteLine("Enter New Discount Percentage");
                    double discount = Convert.ToDouble(Console.ReadLine());
                    Product.UpdateDiscount(discount);
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class Product
{
    static double Discount = 10.0;
    public string ProductName;
    public double Price;
    public int Quantity;
    readonly int ProductID;
    static int ProductCounter = 0;

    public Product(string productName, double price, int quantity)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = ++ProductCounter;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount updated to: " + Discount + "%");
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}
