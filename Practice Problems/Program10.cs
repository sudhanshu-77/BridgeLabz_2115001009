// 10. Implementing a Bank Transaction System
// 💡 Problem Statement:
// Develop a Bank Account System where:
// Withdraw(double amount) method:
// Throws InsufficientFundsException if withdrawal amount exceeds balance.
// Throws ArgumentException if the amount is negative.
// Handle exceptions in Main().
// Expected Behavior:
// If valid, print "Withdrawal successful, new balance: X".
// If balance is insufficient, throw and handle "Insufficient balance!".
// If the amount is negative, throw and handle "Invalid amount!".
using System;

// Custom exception for insufficient funds
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }

        if (amount > Balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(1000.00);

        try
        {
            Console.WriteLine("Attempting to withdraw $500...");
            account.Withdraw(500);
            
            Console.WriteLine("Attempting to withdraw $600...");
            account.Withdraw(600); // throw InsufficientFundsException
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            Console.WriteLine("Attempting to withdraw -$100...");
            account.Withdraw(-100); // throw ArgumentException
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


