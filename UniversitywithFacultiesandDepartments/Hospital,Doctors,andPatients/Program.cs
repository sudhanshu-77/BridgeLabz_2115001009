// Problem 3: Hospital, Doctors, and Patients (Association and Communication)
// Description: Model a Hospital where Doctor and Patient objects interact through consultations. A doctor can see multiple patients, and each patient can consult multiple doctors.
// Tasks:
// Define a Hospital class containing Doctor and Patient classes.
// Create a method Consult() in the Doctor class to show communication, which would display the consultation between a doctor and a patient.
// Model an association between doctors and patients to show that doctors and patients can have multiple relationships.
// Goal: Practice creating an association with communication between objects by modeling doctor-patient consultations.
using System;
using System.Collections.Generic;

// Patient class representing a patient
class Patient
{
    public string Name { get; set; }

    public Patient(string name)
    {
        Name = name;
    }
}

// Doctor class representing a doctor
class Doctor
{
    public string Name { get; set; }
    public List<Patient> Patients { get; set; }

    public Doctor(string name)
    {
        Name = name;
        Patients = new List<Patient>();
    }

    public void Consult(Patient patient)
    {
        if (!Patients.Contains(patient))
        {
            Patients.Add(patient);
        }
        Console.WriteLine($"Doctor {Name} is consulting with patient {patient.Name}.");
    }
}

// Hospital class containing doctors and patients
class Hospital
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Patient> Patients { get; set; }

    public Hospital(string name)
    {
        Name = name;
        Doctors = new List<Doctor>();
        Patients = new List<Patient>();
    }

    public void AddDoctor(Doctor doctor)
    {
        Doctors.Add(doctor);
    }

    public void AddPatient(Patient patient)
    {
        Patients.Add(patient);
    }
}

// Demonstration of association and communication
class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital("City Hospital");

        Doctor doctor1 = new Doctor("Dr. Adams");
        Doctor doctor2 = new Doctor("Dr. Baker");

        Patient patient1 = new Patient("John Doe");
        Patient patient2 = new Patient("Jane Smith");

        hospital.AddDoctor(doctor1);
        hospital.AddDoctor(doctor2);
        hospital.AddPatient(patient1);
        hospital.AddPatient(patient2);

        doctor1.Consult(patient1);
        doctor2.Consult(patient2);
        doctor1.Consult(patient2);
    }
}




