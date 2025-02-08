using System;

class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in weeks

    // Constructor to initialize the Course's details
    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }
}

// OnlineCourse class inheriting from Course
class OnlineCourse : Course
{
    public string Platform { get; set; }
    public bool IsRecorded { get; set; }

    // Constructor to initialize the OnlineCourse's details
    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }
}

// PaidOnlineCourse class inheriting from OnlineCourse
class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; set; }
    public double Discount { get; set; }

    // Constructor to initialize the PaidOnlineCourse's details
    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
        : base(courseName, duration, platform, isRecorded)
    {
        Fee = fee;
        Discount = discount;
    }
}

class MainCourse
{
    static void Main(string[] args)
    {
        // Create an instance of PaidOnlineCourse
        PaidOnlineCourse course = new PaidOnlineCourse("Advanced C#", 8, "Udemy", true, 199.99, 20);

        // Display course details
        Console.WriteLine($"Course Name: {course.CourseName}, Duration: {course.Duration} weeks, Platform: {course.Platform}, Is Recorded: {course.IsRecorded}, Fee: {course.Fee}, Discount: {course.Discount}%");
    }
}
