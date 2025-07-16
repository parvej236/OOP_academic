using System;

public class UserProfile
{
    private string userId = "";
    private static int userCount = 0;
    private string password = "";
    private string email = "";
    private double accountBalance;

    public UserProfile(string email, string password, double accountBalance)
    {
        this.email = email;
        this.password = password;
        this.accountBalance = accountBalance;

        userCount++;
        userId = $"USR{userCount:D3}";
    }

    public string UserId
    {
        get { return userId; }
    }

    public string Password
    {
        get
        {
            return "Not allowed";
        }
        set { password = value; }
    }

    public string Email
    {
        get
        {
            if(email.Contains("@"))
            {
                return email;
            }
            else
            {
                return "Invalid email format";
            }
        }

        set
        {
            if (value.Contains("@"))
            {
                email = value;
            }
            else
            {
                Console.WriteLine("Invalid email format");
            }
        }
    }

    public double AccountBalance
    {
        get { return accountBalance; }
    }

    public void addBalance(double amount)
    {
        if (amount > 0)
        {
            accountBalance += amount;
        }
        else
        {
            Console.WriteLine("Amount must be positive");
        }
    }

    public void makePurchase(double price)
    {
        if (price > 0 && price <= accountBalance)
        {
            accountBalance -= price;
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid price");
        }
    }

    public void changeEmail(string newEmail)
    {
        if (newEmail.Contains("@"))
        {
            email = newEmail;
        }
        else
        {
            Console.WriteLine("Invalid email format");
        }
    }

    public bool authenticate(string pass)
    {
        return password == pass;
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        UserProfile user = new UserProfile("u2304086@student.cuet.ac.bd", "passId86", 1000.0);

        Console.WriteLine($"User ID: {user.UserId}");
        Console.WriteLine($"Email: {user.Email}");

        Console.WriteLine($"Account Balance: {user.AccountBalance}");

        Console.WriteLine($"Password: {user.Password}");

        user.addBalance(500);
        Console.WriteLine($"New Account Balance: {user.AccountBalance}");

        user.makePurchase(200);
        Console.WriteLine($"Account Balance after purchase: {user.AccountBalance}");

        user.changeEmail("parvej@gmail.com");
        Console.WriteLine($"New Email: {user.Email}");


        bool isValid = user.authenticate("passId86");
        Console.WriteLine($"Authentication result: {isValid}");
    }
}
