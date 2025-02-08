using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Constructor to initialize the BankAccount's details
    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}

// SavingsAccount class inheriting from BankAccount
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    // Constructor to initialize the SavingsAccount's details
    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    // Method to display account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}

// CheckingAccount class inheriting from BankAccount
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    // Constructor to initialize the CheckingAccount's details
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    // Method to display account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }
}

// FixedDepositAccount class inheriting from BankAccount
class FixedDepositAccount : BankAccount
{
    public int DepositTerm { get; set; } // Term in months

    // Constructor to initialize the FixedDepositAccount's details
    public FixedDepositAccount(string accountNumber, double balance, int depositTerm)
        : base(accountNumber, balance)
    {
        DepositTerm = depositTerm;
    }

    // Method to display account type
    public void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }
}

class MainBankAccount
{
    static void Main(string[] args)
    {
        // Create instances of SavingsAccount, CheckingAccount, and FixedDepositAccount
        SavingsAccount savings = new SavingsAccount("SA123", 1000, 3.5);
        CheckingAccount checking = new CheckingAccount("CA123", 500, 100);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount("FD123", 5000, 12);

        // Display account types
        savings.DisplayAccountType();
        checking.DisplayAccountType();
        fixedDeposit.DisplayAccountType();
    }
}
