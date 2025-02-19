
using System;
using System.Collections.Generic;

// Abstract class representing a job role
public abstract class JobRole
{
    public string RoleName { get; set; }

    public JobRole(string roleName)
    {
        RoleName = roleName;
    }

    public abstract string GetRequiredSkills();
}

// Specific job roles
public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer() : base("Software Engineer") { }

    public override string GetRequiredSkills()
    {
        return "C#, .NET, SQL, Problem Solving";
    }
}

public class DataScientist : JobRole
{
    public DataScientist() : base("Data Scientist") { }

    public override string GetRequiredSkills()
    {
        return "Python, Machine Learning, Data Analysis";
    }
}

// Generic class for resumes
public class Resume<T> where T : JobRole
{
    public string CandidateName { get; set; }
    public T JobRole { get; set; }

    public Resume(string candidateName, T jobRole)
    {
        CandidateName = candidateName;
        JobRole = jobRole;
    }

    public void DisplayResumeInfo()
    {
        Console.WriteLine($"Candidate: {CandidateName}, Applying for: {JobRole.RoleName}");
        Console.WriteLine($"Required Skills: {JobRole.GetRequiredSkills()}");
    }
}

// Resume screening system
public class ResumeScreeningSystem
{
    private List<object> resumes = new List<object>();

    public void AddResume<T>(Resume<T> resume) where T : JobRole
    {
        resumes.Add(resume);
    }

    public void DisplayResumes()
    {
        Console.WriteLine("Resumes in Screening Pipeline:");
        foreach (var resume in resumes)
        {
            if (resume is Resume<JobRole> jobRoleResume)
            {
                jobRoleResume.DisplayResumeInfo();
            }
        }
    }
}


public class Program
{
    public static void Main()
    {
        var screeningSystem = new ResumeScreeningSystem();

        while (true)
        {
            Console.WriteLine("\n1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Display Resumes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddResume<SoftwareEngineer>(screeningSystem);
                    break;

                case "2":
                    AddResume<DataScientist>(screeningSystem);
                    break;

                case "3":
                    screeningSystem.DisplayResumes();
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

    static void AddResume<T>(ResumeScreeningSystem screeningSystem) where T : JobRole, new()
    {
        Console.Write("Enter Candidate Name: ");
        string name = Console.ReadLine();

        T jobRole = new T();
        Resume<T> resume = new Resume<T>(name, jobRole);
        screeningSystem.AddResume(resume);
        Console.WriteLine($"{typeof(T).Name} resume added.");
    }
}


