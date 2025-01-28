using System;

class Person
{
    // Fields
    private string name;
    private int age;

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method to display details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of the Person class
        Person person1 = new Person("Justice", 25);
        
        // Call the method to display details
        person1.DisplayDetails();
    }
}
