
using System;
using System.Collections.Generic;

// Interface representing a meal plan
public interface IMealPlan
{
    string MealName { get; set; }
    int Calories { get; set; }

    string GetMealType();
}

// Specific meal plan types
public class VegetarianMeal : IMealPlan
{
    public string MealName { get; set; }
    public int Calories { get; set; }

    public VegetarianMeal(string mealName, int calories)
    {
        MealName = mealName;
        Calories = calories;
    }

    public string GetMealType()
    {
        return "Vegetarian";
    }
}

public class VeganMeal : IMealPlan
{
    public string MealName { get; set; }
    public int Calories { get; set; }

    public VeganMeal(string mealName, int calories)
    {
        MealName = mealName;
        Calories = calories;
    }

    public string GetMealType()
    {
        return "Vegan";
    }
}

// Generic class for meals
public class Meal<T> where T : IMealPlan
{
    public T MealDetails { get; set; }

    public Meal(T mealDetails)
    {
        MealDetails = mealDetails;
    }

    public void DisplayMealInfo()
    {
        Console.WriteLine($"{MealDetails.MealName} ({MealDetails.Calories} calories) - Type: {MealDetails.GetMealType()}");
    }
}

// Meal plan generator class
public class MealPlanGenerator
{
    private List<object> meals = new List<object>();

    public void AddMeal<T>(Meal<T> meal) where T : IMealPlan
    {
        meals.Add(meal);
    }

    public void DisplayMeals()
    {
        Console.WriteLine("Meal Plans:");
        foreach (var meal in meals)
        {
            if (meal is Meal<IMealPlan> mealPlan)
            {
                mealPlan.DisplayMealInfo();
            }
        }
    }

    public void GenerateMealPlan<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine($"Generating meal plan for: {meal.MealName}");
    }
}

public class Program
{
    public static void Main()
    {
        var mealPlanGenerator = new MealPlanGenerator();

        while (true)
        {
            Console.WriteLine("\n1. Add Vegetarian Meal");
            Console.WriteLine("2. Add Vegan Meal");
            Console.WriteLine("3. Display Meals");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddMeal<VegetarianMeal>(mealPlanGenerator);
                    break;

                case "2":
                    AddMeal<VeganMeal>(mealPlanGenerator);
                    break;

                case "3":
                    mealPlanGenerator.DisplayMeals();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void AddMeal<T>(MealPlanGenerator mealPlanGenerator) where T : IMealPlan, new()
    {
        Console.Write("Enter Meal Name: ");
        string mealName = Console.ReadLine();
        Console.Write("Enter Calories: ");
        if (int.TryParse(Console.ReadLine(), out int calories))
        {
            T meal = (T)Activator.CreateInstance(typeof(T), mealName, calories);
            Meal<T> mealInstance = new Meal<T>(meal);
            mealPlanGenerator.AddMeal(mealInstance);
            Console.WriteLine($"{typeof(T).Name} meal added.");
        }
        else
        {
            Console.WriteLine("Invalid input for calories. Please enter a valid number.");
        }
    }
}


