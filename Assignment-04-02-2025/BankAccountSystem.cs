// Sample Program 1: Bank Account System
// Create a BankAccount class with the following features:
// static: 
// A static variable bankName shared across all accounts.
// A static method GetTotalAccounts() to display the total number of accounts.
// this: 
// Use this to resolve ambiguity in the constructor when initializing AccountHolderName and AccountNumber.
// readonly: 
// Use a readonly variable AccountNumber to ensure it cannot be changed once assigned.
// is operator: 
// Check if an account object is an instance of the BankAccount class before displaying its details.



using System;

class BankAccountSystem
{
    // Main method to handle user interaction
    public static void Print()
    {
        while (true)
        {
            // Display menu options
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Display Total Accounts");
            Console.WriteLine("3. Exit");

            // Read user choice
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Add a new bank account
                    Console.WriteLine("Enter the Account Holder Name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the Account Number");
                    int accountNumber = Convert.ToInt32(Console.ReadLine());

                    // Create a new BankAccount object
                    BankAccount account = new BankAccount(name, accountNumber);

                    // Check if the object is an instance of BankAccount and display details
                    if (account is BankAccount)
                    {
                        account.DisplayDetails();
                    }
                    break;

                case 2:
                    // Display the total number of accounts
                    BankAccount.GetTotalAccounts();
                    break;

                case 3:
                    // Exit the program
                    return;

                default:
                    // Handle invalid input
                    Console.WriteLine("INVALID FUNCTION");
                    break;
            }
        }
    }
}

class BankAccount
{
    // Static variable shared across all instances
    static string BankName = "ICICI BANK";

    // Instance variables
    public string AccountHolderName;
    readonly int AccountNumber;
    public static int TotalAccount;

    // Constructor to initialize a new bank account
    public BankAccount(string accountHolderName, int accountNumber)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        TotalAccount++;
    }

    // Static method to display the total number of accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total BankAccounts in " + BankName + ": " + TotalAccount);
    }

    // Method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("BankName: " + BankName);
        Console.WriteLine("AccountHolder Name: " + AccountHolderName);
        GetTotalAccounts();
        Console.WriteLine("AccountNumber: " + AccountNumber);
    }
}
