
// Sample Program 7: Hospital Management System
// Create a Patient class with the following features:
// static: 
// A static variable HospitalName shared among all patients.
// A static method GetTotalPatients() to count the total patients admitted.
// this: 
// Use this to initialize Name, Age, and Ailment in the constructor.
// readonly: 
// Use a readonly variable PatientID to uniquely identify each patient.
// is operator: 
// Check if an object is an instance of the Patient class before displaying its details.


using System;

class HospitalManagement
{
    public static void Print()
    {
        while (true)
        {
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Get Total Patients");
            Console.WriteLine("3. Exit");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Patient Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Age");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Ailment");
                    string ailment = Console.ReadLine();

                    Patient patient = new Patient(name, age, ailment);

                    if (patient is Patient)
                    {
                        patient.DisplayDetails();
                    }
                    break;

                case 2:
                    Patient.GetTotalPatients();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class Patient
{
    static string HospitalName = "City Hospital";
    public string Name;
    public int Age;
    public string Ailment;
    readonly int PatientID;
    static int PatientCounter = 0;

    public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = ++PatientCounter;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients in " + HospitalName + ": " + PatientCounter);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Ailment: " + Ailment);
        Console.WriteLine("Patient ID: " + PatientID);
    }
}
