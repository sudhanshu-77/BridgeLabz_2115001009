// 11.            Write a program Quadratic to find the roots of the equation ax2+ bx + c. Use Math functions Math.pow() and Math.sqrt()
// Hint => 
// a.               Take a, b, and c as input values to find the roots of x.
// b.               The roots are computed using the following formulae
// delta = b2+ 4*a*c
// If delta is positive the find the two roots using formulae 
// root1 of x = (-b + delta)/(2*a) 
// root1 of x = (-b - delta)/(2*a)
// If delta is zero then there is only one root of x  
// root of x = -b/(2*a)
// If delta is negative return empty array or nothing 
// c.  Write a Method to find find the roots of a quadratic equation and return the roots

using System;

class Question11
{
    public void FindQuadraticRoots()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        // Find roots of the quadratic equation
        double[] roots = FindRoots(a, b, c);

        // Display results
        if (roots.Length == 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The equation has one root: {roots[0]}");
        }
        else
        {
            Console.WriteLine($"The equation has two roots: {roots[0]} and {roots[1]}");
        }
    }

    private double[] FindRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta < 0)
        {
            return new double[0]; // No real roots
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            return new double[] { root }; // One root
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double root1 = (-b + sqrtDelta) / (2 * a);
            double root2 = (-b - sqrtDelta) / (2 * a);
            return new double[] { root1, root2 }; // Two roots
        }
    }
}
