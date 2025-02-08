using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor to initialize the Animal's name and age
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method to be overridden by subclasses to make a sound
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
   
    public Dog(string name, int age) : base(name, age) { }

  
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}


class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

   
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


class Bird : Animal
{
   
    public Bird(string name, int age) : base(name, age) { }

    
    public override void MakeSound()
    {
        Console.WriteLine("Tweet");
    }
}

// Main class to demonstrate polymorphism
class MainAnimal
{
    static void Main(string[] args)
    {
        // Create instances of Dog, Cat, and Bird
        Animal dog = new Dog("Buddy", 3);
        Animal cat = new Cat("Whiskers", 2);
        Animal bird = new Bird("Tweety", 1);

        // Call the MakeSound method on each instance
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}
