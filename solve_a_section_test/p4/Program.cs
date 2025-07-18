using System;

class Account
{
    private double balance;

    public virtual double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
    }
}

class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public double CalculateInterest()
    {
        return Balance * InterestRate;
    }
}

class CheckingAccount : Account
{
    public double TransactionFee { get; set; }

    // Read-only property to hide base Balance and show total with fee (for display only)
    public new double Balance
    {
        get { return base.Balance + TransactionFee; }
    }

    // Set initial balance using base class
    public void SetInitialBalance(double amount)
    {
        base.Balance = amount;
    }

    public override void Deposit(double amount)
    {
        base.Deposit(amount - TransactionFee);
    }

    public double BaseBalance
    {
        get { return base.Balance; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Savings Account
        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.Balance = 1000.0;
        savingsAccount.Deposit(500.0);
        savingsAccount.InterestRate = 0.05;
        double interest = savingsAccount.CalculateInterest();

        Console.WriteLine("Savings Account:");
        Console.WriteLine("Balance: $" + savingsAccount.Balance.ToString("F2"));
        Console.WriteLine("Interest Earned: $" + interest.ToString("F2"));

        // Checking Account
        CheckingAccount checkingAccount = new CheckingAccount();
        checkingAccount.TransactionFee = 2.0;
        checkingAccount.SetInitialBalance(2000.0); // Set initial balance using method
        checkingAccount.Deposit(300.0);            // Apply fee during deposit

        Console.WriteLine("\nChecking Account:");
        Console.WriteLine("Balance: $" + checkingAccount.Balance.ToString("F2"));     // Includes extra fee
        Console.WriteLine("Base Balance: $" + checkingAccount.BaseBalance.ToString("F2")); // Actual balance in base
    }
}
