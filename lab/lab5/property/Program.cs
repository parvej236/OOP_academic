using System;

public class MyClass
{
    public int Age { get; set; }
    public string Name { get; set; }

    // public string Name
    // {
    //     get { return name; }
    //     set { name = value; }
    // }

}

public class Bank {
    private string name = "";
    private int acountNumer;
    private string password = "";
    private int balance = 500;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int AcountNumer
    {
        get { return acountNumer; }
        set { acountNumer = value; }
    }

    public string Password
    {
        set { password = value; }
    }

    public int Balance
    {
        get { return balance += 10; }
    }

    public int Age
    {
        get { 
            DateTime now = DateTime.Now;
            int birthYear = now.Year - age;
            return birthYear;
        }
        set {
            if (value < 1) {
                Console.WriteLine("Age cannot be less than zero");
                Environment.Exit(1);
            } else {
                age = value;
            }
         }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bank bank1 = new Bank();
        bank1.Name = "Bangladesh Bank";
        bank1.AcountNumer = 123456;
        bank1.Password = "1234";
        bank1.Age = 12;
        Console.WriteLine($"Bank Name: {bank1.Name}, Account Number: {bank1.AcountNumer}, Balance: {bank1.Balance}, Age: {bank1.Age}"); // bank1.Balance will be 510 due to the increment in the Balance property
        Console.WriteLine($"Balance after deposit: {bank1.Balance}"); // balance will be 520 after this call
        Console.WriteLine($"Balance after deposit: {bank1.Balance}"); // balance will be 530 after this call

        // Bank bank2 = new Bank();
        // bank2.Name = "Sonali Bank";
        // bank2.AcountNumer = 235645;
        // bank2.Password = "parvej";
        // bank2.Age = 30;
        // Console.WriteLine($"Bank Name: {bank2.Name}, Acoount Number: {bank2.AcountNumer}, Balance: {bank2.Balance}, Age: {bank2.Age}");      



        // MyClass myClass = new MyClass();
        
        // // myClass.setAge(25);
        // // myClass.setName("John Doe");
        // // Console.WriteLine($"Name: {myClass.getName()}, Age: {myClass.getAge()}");


        // myClass.Age = 25;
        // myClass.Name = "John Doe";
        // Console.WriteLine($"Name: {myClass.Name}, Age: {myClass.Age}");
    }
}