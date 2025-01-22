// 10. Create a program to divide N number of chocolates among M children.
// Hint:
// Get an integer value from the user for numberOfChocolates and numberOfChildren.
// Find the number of chocolates each child gets and the number of remaining chocolates.
// Display the results.
// I/P => numberOfChocolates, numberOfChildren
// O/P => The number of chocolates each child gets is _0__ and the number of remaining chocolates is _15__

using System;

class Question10
{
    public void DivideChocolates()
    {
        // Taking user input for number of chocolates and children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calculating chocolates per child and remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Displaying the result
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
    }
}
