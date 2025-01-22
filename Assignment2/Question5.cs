// 5. Suppose you have to divide 14 pens among 3 students equally. Write a program to find how many pens each student will get if the pens must be divided equally. Also, find the remaining non-distributed pens.
// Hint:
// Use Modulus Operator (%) to find the reminder.
// Use Division Operator to find the Quantity of pens
// I/P => NONE
// O/P => The Pen Per Student is _ 4 __ and the remaining pen not distributed is _2__


using System;

class Question5
{
    public void DistributePens()
    {
        // Total pens and number of students
        int totalPens = 14;
        int students = 3;

        // Calculate pens per student and remaining pens
        int pensPerStudent = totalPens / students;
        int remainingPens = totalPens % students;

        // Display the result
        Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}");
    }
}
