using System;
using System.Collections.Generic;

class Student
{
    public int StudentID { get; set; }
    private string name;
    protected string contactNo;

    public void SetName(string n) => name = n;
    public string GetName() => name;

}

class Admin : Student
{
    public void SetContact(string c) => contactNo = c;
    public string GetContact() => contactNo;
}

class Program
{
    static void Main()
    {
        List<Admin> students = new List<Admin>();

        while (true)
        {
            Console.WriteLine("====== MENU ======");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Student Summary");
            Console.WriteLine("3. Search Student by ID");
            Console.WriteLine("4. Update Contact No.");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. Delete Student");
            Console.WriteLine("7. Student Statistics (Batch & Dept)");
            Console.Write("Enter choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
                continue;
            }
            Console.WriteLine();

            if (choice == 1)
            {
                Admin s = new Admin();

                Console.Write("Enter Student ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Invalid ID.\n");
                    continue;
                }
                s.StudentID = id;

                Console.Write("Enter Name: ");
                s.SetName(Console.ReadLine());

                Console.Write("Enter Contact No: ");
                s.SetContact(Console.ReadLine());

                students.Add(s);
                Console.WriteLine("Student added.\n");
            }
            else if (choice == 2)
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students to show.\n");
                }
                else
                {
                    foreach (Admin s in students)
                    {
                        Console.WriteLine($"ID: {s.StudentID}, Name: {s.GetName()}, Contact: {s.GetContact()}");
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 3)
            {
                Console.Write("Enter ID to search: ");
                if (!int.TryParse(Console.ReadLine(), out int searchId))
                {
                    Console.WriteLine("Invalid ID.\n");
                    continue;
                }

                bool found = false;
                foreach (Admin s in students)
                {
                    if (s.StudentID == searchId)
                    {
                        Console.WriteLine($"Name: {s.GetName()}, Contact: {s.GetContact()}\n");
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("Student not found.\n");
            }
            else if (choice == 4)
            {
                Console.Write("Enter ID to update: ");
                if (!int.TryParse(Console.ReadLine(), out int updateId))
                {
                    Console.WriteLine("Invalid ID.\n");
                    continue;
                }

                bool found = false;
                foreach (Admin s in students)
                {
                    if (s.StudentID == updateId)
                    {
                        Console.Write("Enter new contact: ");
                        s.SetContact(Console.ReadLine());

                        Console.WriteLine("Contact updated.\n");
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("Student not found.\n");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else if (choice == 6)
            {
                Console.Write("Enter ID to delete: ");
                if (!int.TryParse(Console.ReadLine(), out int deleteId))
                {
                    Console.WriteLine("Invalid ID.\n");
                    continue;
                }

                bool found = false;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].StudentID == deleteId)
                    {
                        students.RemoveAt(i);
                        Console.WriteLine("Student deleted.\n");
                        found = true;
                        break;
                    }
                }
                if (!found) Console.WriteLine("Student not found.\n");
            }
            else if (choice == 7)
            {
                int batch19 = 0, batch20 = 0, batch21 = 0, batch22 = 0;
                int ce = 0, efe = 0, me = 0, cse = 0;

                foreach (Admin s in students)
                {
                    string idStr = s.StudentID.ToString("D6");
                    string batch = idStr.Substring(0, 2);
                    string dept = idStr.Substring(2, 2);

                    if (batch == "19") batch19++;
                    else if (batch == "20") batch20++;
                    else if (batch == "21") batch21++;
                    else if (batch == "22") batch22++;

                    if (dept == "01") ce++;
                    else if (dept == "02") efe++;
                    else if (dept == "03") me++;
                    else if (dept == "04") cse++;
                }

                Console.WriteLine("Batch-wise Count:");
                Console.WriteLine($"19 = {batch19}");
                Console.WriteLine($"20 = {batch20}");
                Console.WriteLine($"21 = {batch21}");
                Console.WriteLine($"22 = {batch22}");

                Console.WriteLine("\n Department-wise Count:");
                Console.WriteLine($"CE (01) = {ce}");
                Console.WriteLine($"EFE (02) = {efe}");
                Console.WriteLine($"ME (03) = {me}");
                Console.WriteLine($"CSE (04) = {cse}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid choice.\n");
            }
        }
    }
}
