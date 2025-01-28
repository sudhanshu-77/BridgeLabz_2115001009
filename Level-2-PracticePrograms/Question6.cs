// 6.               Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g. 
// public static double convertFarhenheitToCelsius(double farhenheit) => 
// a.               Method to convert Fahrenheit to Celsius and return the value. Use the following code  double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
// b.               Method to convert Celsius to Fahrenheit and return the value. Use the following code  double celsius2farhenheit = (celsius * 9 / 5) + 32;
// c.                Method to convert pounds to kilograms and return the value. Use the following code  double pounds2kilograms = 0.453592;
// d.               Method to convert kilograms to pounds and return the value. Use the following code  double kilograms2pounds = 2.20462; 
// e.               Method to convert gallons to liters and return the value. Use following code to convert   double gallons2liters = 3.78541; 
// f.                 Method to convert liters to gallons and return the value. Use following code to convert  double liters2gallons = 0.264172; 
// using System;

class Question6
{
    public void UnitConverterTemperature()
    {
        Console.WriteLine("Temperature and Weight Converter");

        // Convert Fahrenheit to Celsius
        double fahrenheit = 98.6;
        double celsius = ConvertFahrenheitToCelsius(fahrenheit);
        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");

        // Convert Celsius to Fahrenheit
        celsius = 37;
        fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} Celsius is {fahrenheit} Fahrenheit");

        // Convert pounds to kilograms
        double pounds = 150;
        double kilograms = ConvertPoundsToKilograms(pounds);
        Console.WriteLine($"{pounds} pounds is {kilograms} kilograms");

        // Convert kilograms to pounds
        kilograms = 68;
        pounds = ConvertKilogramsToPounds(kilograms);
        Console.WriteLine($"{kilograms} kilograms is {pounds} pounds");

        // Convert gallons to liters
        double gallons = 5;
        double liters = ConvertGallonsToLiters(gallons);
        Console.WriteLine($"{gallons} gallons is {liters} liters");

        // Convert liters to gallons
        liters = 18.9;
        gallons = ConvertLitersToGallons(liters);
        Console.WriteLine($"{liters} liters is {gallons} gallons");
    }

    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
}
