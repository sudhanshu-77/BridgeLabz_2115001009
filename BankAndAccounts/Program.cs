// Problem 2: Bank and Account Holders (Association)
// Description: Model a relationship where a Bank has Customer objects associated with it. A Customer can have multiple bank accounts, and each account is linked to a Bank.
// Tasks:
// Define a Bank class and a Customer class.
// Use an association relationship to show that each Customer has an account in a Bank.
// Implement methods that enable communication, such as OpenAccount() in the Bank class and ViewBalance() in the Customer class.
// Goal: Illustrate association by setting up a relationship between customers and the bank.
using System;
using System.Collections.Generic;

// Customer class with a list of accounts
class Customer
{
    public string Name { get; set; }
    public List<BankAccount> Accounts { get; set; }

    public Customer(string name)
    {
        Name = name;
        Accounts = new List<BankAccount>();
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Customer: {Name}");
        foreach (var account in Accounts)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");
        }
    }
}

// BankAccount class representing a bank account
class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }
}

// Bank class with methods to open accounts
class Bank
{
    public string Name { get; set; }
    public List<Customer> Customers { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
    }

    public void OpenAccount(Customer customer, BankAccount account)
    {
        customer.Accounts.Add(account);
        if (!Customers.Contains(customer))
        {
            Customers.Add(customer);
        }
    }
}

// Demonstration of association
class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank("National Bank");

        Customer customer1 = new Customer("Alice");
        BankAccount account1 = new BankAccount("123456", 1000);
        bank.OpenAccount(customer1, account1);

        Customer customer2 = new Customer("Bob");
        BankAccount account2 = new BankAccount("789012", 2000);
        bank.OpenAccount(customer2, account2);

        customer1.ViewBalance();
        customer2.ViewBalance();
    }
}

