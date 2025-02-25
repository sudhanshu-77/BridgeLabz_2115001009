// Exercise 1: Use Method Overriding Correctly
// Problem Statement: Create a parent class Animal with a method MakeSound(). Then, create a Dog class that overrides this method using override.
// Steps to Follow:
// Define a MakeSound() method in the Animal class.
// Override it in the Dog class with override.
// Instantiate Dog and call MakeSound().
using System;
using System.Reflection;


class Animal
{
    // Marking the method as obsolete
    [Obsolete("Use the Dog class for specific sounds instead.")]
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}


[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
    public string Message { get; }

    public LogExecutionTimeAttribute(string message = "Method executed in: ")
    {
        Message = message;
    }
}


class Dog : Animal
{
    // Override the base class method and add custom attribute
    [LogExecutionTime("Dog sound executed in: ")]
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks: Woof woof!");
    }
}

class Program1
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        myAnimal.MakeSound();  //  show an Obsolete warning

        Dog myDog = new Dog();

        // Using reflection to process the custom attribute
        MethodInfo method = myDog.GetType().GetMethod("MakeSound");

        if (method.GetCustomAttribute(typeof(LogExecutionTimeAttribute)) is LogExecutionTimeAttribute attribute)
        {
            var startTime = DateTime.Now;
            myDog.MakeSound();
            var endTime = DateTime.Now;

            Console.WriteLine(attribute.Message + (endTime - startTime).TotalMilliseconds + "ms");
        }
    }
}



