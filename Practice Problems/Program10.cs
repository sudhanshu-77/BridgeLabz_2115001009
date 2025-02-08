using System;

class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

interface Worker
{
    void PerformDuties();
}

class Chef : Person, Worker
{
    public Chef(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Cooking food");
    }
}

class Waiter : Person, Worker
{
    public Waiter(string name, int id) : base(name, id) { }

    public void PerformDuties()
    {
        Console.WriteLine("Serving customers");
    }
}

class MainRestaurant
{
    static void Main(string[] args)
    {
        // Create instances of Chef and Waiter
        Worker chef = new Chef("Gordon", 1);
        Worker waiter = new Waiter("John", 2);

        // Perform duties
        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
