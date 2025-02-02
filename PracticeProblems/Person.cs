// Person Class (Copy Constructor)
// Create a Person class with a copy constructor that clones another person's attributes.

using System;

class Person
{
    private string name;
    private int age;

    // Parameterized constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy constructor
    public Person(Person other)
    {
        this.name = other.name;
        this.age = other.age;
    }

    // Method to display person details
    public void DisplayPersonDetails()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

