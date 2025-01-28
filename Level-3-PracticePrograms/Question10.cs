// 10.             Write a program to find the 3 points that are collinear using the slope formulae and area of triangle formulae. check  A (2, 4), B (4, 6) and C (6, 8) are Collinear for sampling. 
// Hint => 
// a.                Take inputs for 3 points x1, y1, x2, y2, and x3, y3
// b.                Write a Method to find the 3 points that are collinear using the slope formula. The 3 points A(x1,y1), b(x2,y2), and c(x3,y3) are collinear if the slopes formed by 3 points ab, bc, and cd are equal. 
// slope AB = (y2 - y1)/(x2 - x1), slope BC = (y3 - y2)/(x3 - x3)
// slope AC = (y3 - y1)/(x3 - x1) Points are collinear if
// slope AB = slope BC = slope Ac
// c.  The method to find the three points is collinear using the area of the triangle formula. The Three points are collinear if the area of the triangle formed by three points is 0. The area of a triangle is 
       

// area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2))

using System;

class Question10
{
    public void CheckCollinearity()
    {
        Console.Write("Enter x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Enter y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Enter x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Enter y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("Enter x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Enter y3: ");
        double y3 = double.Parse(Console.ReadLine());

        // Check collinearity using slope
        bool areCollinearSlope = CheckCollinearityUsingSlope(x1, y1, x2, y2, x3, y3);

        // Check collinearity using area
        bool areCollinearArea = CheckCollinearityUsingArea(x1, y1, x2, y2, x3, y3);

        // Display results
        Console.WriteLine($"Are points collinear using slope method? {areCollinearSlope}");
        Console.WriteLine($"Are points collinear using area method? {areCollinearArea}");
    }

    private bool CheckCollinearityUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    private bool CheckCollinearityUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}
