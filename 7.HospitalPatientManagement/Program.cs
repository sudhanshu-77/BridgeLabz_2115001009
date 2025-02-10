// 7. Hospital Patient Management
// Description: Design a system to manage patients in a hospital.
// Abstract Class:
// Create an abstract class Patient with fields: patientId, name, and age.
// Add an abstract method CalculateBill().
// Implement a concrete method GetPatientDetails().
// Subclasses:
// Extend Patient into InPatient and OutPatient.
// Implement CalculateBill() differently for each subclass.
// Interface:
// Implement an interface IMedicalRecord.
// Define methods AddRecord() and ViewRecords().
// Encapsulation:
// Protect sensitive patient data like diagnosis and medical history.
// Polymorphism:
// Use a Patient reference to handle different patient types dynamically.
// Display billing details based on polymorphic behavior.

using System;
using System.Collections.Generic;

// Abstract class representing a Patient
abstract class Patient
{
    private string patientId;
    private string name;
    private int age;

    public string PatientId { get => patientId; set => patientId = value; }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}

// Interface for medical records
interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

// In-patient class
class InPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();

    public override double CalculateBill()
    {
        return 1000; //   bill calculation
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}

// Out-patient class
class OutPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();

    public override double CalculateBill()
    {
        return 200; //   bill calculation
    }

    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine(record);
        }
    }
}

class HospitalPatientManagement
{
    static void Main(string[] args)
    {
        List<Patient> patients = new List<Patient>();

        Console.Write("Enter the number of patients: ");
        int numberOfPatients = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPatients; i++)
        {
            Console.WriteLine($"Enter details for patient {i + 1}:");
            Console.Write("Enter Patient ID: ");
            string patientId = Console.ReadLine();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Is the patient an In-Patient (yes/no)? ");
            string patientType = Console.ReadLine().ToLower();

            Patient patient;
            if (patientType == "yes")
            {
                patient = new InPatient { PatientId = patientId, Name = name, Age = age };
            }
            else
            {
                patient = new OutPatient { PatientId = patientId, Name = name, Age = age };
            }

            patients.Add(patient);

            if (patient is IMedicalRecord medicalRecord)
            {
                Console.Write("Enter a medical record for the patient: ");
                string record = Console.ReadLine();
                medicalRecord.AddRecord(record);
            }
        }

        // Process each patient and display details
        foreach (var patient in patients)
        {
            patient.GetPatientDetails();
            Console.WriteLine($"Bill: {patient.CalculateBill()}");

            if (patient is IMedicalRecord medicalRecord)
            {
                medicalRecord.ViewRecords();
            }
        }
    }
}
