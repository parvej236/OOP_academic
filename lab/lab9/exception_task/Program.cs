using System;

class BankAccount
{
    int money = 0;

    public void Deposit(int amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", "The amount should not less than or equal to 0.");
            }
            money += amount;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Custom Exception Alert: " + ex.Message);
        }
    }

    public void Withdraw(int amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", "The amount should not less than or equal to 0.");
            }
            if (amount > money)
            {
                throw new InvalidOperationException("Insufficient withdrawl amount.");
            }
            money -= amount;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Custom Exception Alert: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Custom Exception Alert: " + ex.Message);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + money);
    }
}

class Program
{
    static void Main(string[] args) {

        BankAccount account = new BankAccount();
        account.Deposit(100);
        account.CheckBalance();


        account.Withdraw(50);
        account.CheckBalance();

        account.Deposit(-20);
        account.Withdraw(200);
        account.Withdraw(-10);

        account.CheckBalance();
    }
}