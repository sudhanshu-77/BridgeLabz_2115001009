// Self Problems
// Problem 1: School and Students with Courses (Association and Aggregation)
// Description: Model a School with multiple Student objects, where each student can enroll in multiple courses, and each course can have multiple students.
// Tasks:
// Define School, Student, and Course classes.
// Model an association between Student and Course to show that students can enroll in multiple courses.
// Model an aggregation relationship between School and Student.
// Demonstrate how a student can view the courses they are enrolled in and how a course can show its enrolled students.
// Goal: Practice association by modeling many-to-many relationships between students and courses.
using System;
using System.Collections.Generic;

// Course class representing a course
class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public void DisplayEnrolledStudents()
    {
        Console.WriteLine($"Course: {CourseName}");
        foreach (var student in EnrolledStudents)
        {
            Console.WriteLine($"Student: {student.Name}");
        }
    }
}

// Student class representing a student
class Student
{
    public string Name { get; set; }
    public List<Course> Courses { get; set; }

    public Student(string name)
    {
        Name = name;
        Courses = new List<Course>();
    }

    public void EnrollInCourse(Course course)
    {
        Courses.Add(course);
        course.EnrollStudent(this);
    }

    public void DisplayCourses()
    {
        Console.WriteLine($"Student: {Name}");
        foreach (var course in Courses)
        {
            Console.WriteLine($"Enrolled in: {course.CourseName}");
        }
    }
}

// School class containing students
class School
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }

    public School(string name)
    {
        Name = name;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}

// Demonstration of association and aggregation
class Program
{
    static void Main(string[] args)
    {
        School school = new School("Greenwood High");

        Student student1 = new Student("Ravi");
        Student student2 = new Student("Bob");

        Course course1 = new Course("Mathematics");
        Course course2 = new Course("Science");

        student1.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);
        student2.EnrollInCourse(course1);

        school.AddStudent(student1);
        school.AddStudent(student2);

        student1.DisplayCourses();
        student2.DisplayCourses();

        course1.DisplayEnrolledStudents();
        course2.DisplayEnrolledStudents();
    }
}

