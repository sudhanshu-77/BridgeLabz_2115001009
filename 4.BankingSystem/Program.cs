// 4. Banking System
// Description: Create a banking system with different account types:
// Define an abstract class BankAccount with fields like accountNumber, holderName, and balance.
// Add methods like Deposit(double amount), Withdraw(double amount), and an abstract method CalculateInterest().
// Implement subclasses SavingsAccount and CurrentAccount with unique interest calculations.
// Create an interface ILoanable with methods ApplyForLoan() and CalculateLoanEligibility().
// Use encapsulation to secure account details and restrict unauthorized access.
// Demonstrate polymorphism by processing different account types and calculating interest dynamically.

using System;
using System.Collections.Generic;

// Abstract class representing a Bank Account
abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    public string AccountNumber { get => accountNumber; set => accountNumber = value; }
    public string HolderName { get => holderName; set => holderName = value; }
    public double Balance { get => balance; set => balance = value; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public abstract double CalculateInterest();
}

// Interface for loanable accounts
interface ILoanable
{
    void ApplyForLoan();
    bool CalculateLoanEligibility();
}

// Savings account class
class SavingsAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return Balance * 0.04; //   interest calculation
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Savings Account.");
    }

    public bool CalculateLoanEligibility()
    {
        return Balance > 5000; //   eligibility check
    }
}

// Current account class
class CurrentAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return Balance * 0.02; //   interest calculation
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan application submitted for Current Account.");
    }

    public bool CalculateLoanEligibility()
    {
        return Balance > 10000; //   eligibility check
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>();

        Console.Write("Enter the number of accounts to create: ");
        int numberOfAccounts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfAccounts; i++)
        {
            Console.WriteLine($"Enter details for account {i + 1}:");
            Console.Write("Enter account type (Savings/Current): ");
            string accountType = Console.ReadLine().Trim().ToLower();

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            Console.Write("Enter holder name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter initial balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account;
            if (accountType == "savings")
            {
                account = new SavingsAccount { AccountNumber = accountNumber, HolderName = holderName, Balance = balance };
            }
            else if (accountType == "current")
            {
                account = new CurrentAccount { AccountNumber = accountNumber, HolderName = holderName, Balance = balance };
            }
            else
            {
                Console.WriteLine("Invalid account type. Skipping this account.");
                continue;
            }

            accounts.Add(account);
        }

        // Process each account and display details
        foreach (var account in accounts)
        {
            Console.WriteLine($"\nAccount Number: {account.AccountNumber}, Holder Name: {account.HolderName}, Balance: {account.Balance}");
            Console.WriteLine($"Interest: {account.CalculateInterest()}");

            if (account is ILoanable loanableAccount)
            {
                loanableAccount.ApplyForLoan();
                Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility()}");
            }
        }
    }
}
