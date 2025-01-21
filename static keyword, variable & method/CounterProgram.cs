//static keyword in C# ?
/* static keyword in C# is used to declare members (variables, methods, properties, constructors, etc.) 
that belong to the type itself rather than an instance of the type.
When a member is declared as static:
-> It is shared among all instances of the class.
-> It can be accessed directly using the class name without creating an instance of the class.
*/
//static variable in C#?
/* Is a variable declared with the static keyword.
-> Belongs to the class rather than any specific instance.
-> Its value is shared across all instances of the class.
-> It is initialized only once, at the time of class loading
*/

using System;

class Counter
{
    // Static variable
    public static int count = 0;

    // Instance method
    public void Increment()
    {
        count++;
    }

    // Static method to display the count
    public static void DisplayCount()
    {
        Console.WriteLine($"Count: {count}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two instances of the Counter class
        Counter obj1 = new Counter();
        Counter obj2 = new Counter();

        // Call Increment() on both instances
        obj1.Increment();
        obj2.Increment();

        // Display the static variable using the class name
        Counter.DisplayCount();

        // Accessing the static variable directly (not recommended)
        Console.WriteLine($"Accessing directly: {Counter.count}");
    }
}

// static method? Why can’t it access instance variables?
/* static method -> Is a method declared with the static keyword.
-> Can be called without creating an object of the class.
-> Operates at the class level, not the instance level.

Why can't it access instance variables?
-> A static method belongs to the class, not any specific instance.
-> Instance variables, on the other hand, belong to a specific object (instance) of the class.
-> Since a static method does not have access to an instance, 
it cannot directly reference instance members, which require an instance to exist.
*/


