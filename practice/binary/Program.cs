using System;

abstract class Employee
{
	public abstract double CalculatePay();
	
	public virtual void DisplayPay()
	{
		Console.WriteLine("Display calculate pay value.");
	}
}

class FullTimeEmployee : Employee
{
	public double MonthlySalary { get; set; }
	
	public FullTimeEmployee(double monthlySalary)
	{
		MonthlySalary = monthlySalary;
	}
	
	public override double CalculatePay()
	{
		reutrn MonthlySalary;
	}
	
	public override void DiplayPay()
	{
		Console.WriteLine("Monthly salary" + CalculatePay());
	}

}

class PartTimeEmployee : Employee
{
	public double HoursWorked { get; set; }
	public double HourlyRate { get; set; }
	public PartTimeEmployee(double hoursWorked, double hourlyRate)
	{
		HoursWorked = hoursWorked;	
		HourlyRate = hourlyRate;
	}
	
	public override double CalculatePary()
	{
		return HoursWorked * HourlyRate;
	}
	
	public override void DisplayPay()
	{
		Console.WriteLine(CalculatePay());
	}
	
	public static PartTimeEmployee operator +(PartTimeEmployee p1, PartTimeEmployee p2)
	{
		return new PartTimeEmployee(p1.HoursWorked + p2.HoursWorked, p1.HourlyRate + p2.HourlyRate);
	}
}

class Program
{
	static void Main(string[] args)
	{
		FullTimeEmployee full = new FullTimeEmployee(5000);
		PartTimeEmployee part = new PartTimeEmployee(800);
		full.DisplayPay();
		part.DisplayPay();
		
		PartTimeEmployee p1 = new PartTimeEmployee(800);
		PartTimeEmployee p2 = new PartTimeEmployee(1200);
		PartTimeEmployee p3 = p1 + p2;
		Console.WriteLine("Combined Hours Worked: " + p3.HoursWorked);
		Console.WriteLine("Hourly Rate: " + p3.HourlyRate);
	}
}