using System;

namespace UniversityCourseManagementSystem
{
    public class Course
    {
        private int id = 0;
        private string title;
        private int creditHours;
        public static int courseCount = 0;
        public Course(string title, int creditHours)
        {
            this.id++;
            this.title = title;
            this.creditHours = creditHours;
        }

        public string GetDetails()
        {
            return $"{id} \t Course \t Title: \"{title}\", Credits: {creditHours}";
        }
    }

    public class Seminar
    {
        private int id = 0;
        private string title;
        private float duration;
        public static int seminarCount = 0;

        public Seminar(string title, float duration)
        {
            this.id++;
            this.title = title;
            this.duration = duration;
        }

        public string GetDetails()
        {
            return $"{id} \t Seminar \t Title: \"{title}\", Duration: {duration} hr";
        }
    }

    public class Lab
    {
        private int id = 0;
        private string title;
        private int equipmentCount;
        public static int labCount = 0;

        public Lab(string title, int equipmentCount)
        {
            this.id++;
            this.title = title;
            this.equipmentCount = equipmentCount;
        }

        public string GetDetails()
        {
            return $"{id} \t Lab \t Title: \"{title}\", Equipment: {equipmentCount}";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            List<Course> courses = new List<Course>();
            List<Seminar> seminars = new List<Seminar>();
            List<Lab> labs = new List<Lab>();

            while (true)
            {
                Console.WriteLine("\nUniversity Course Management System Menu:");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. Add a Seminar");
                Console.WriteLine("3. Add a Lab");
                Console.WriteLine("4. List Subjects");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter course title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter credit hours: ");
                        int creditHours = int.Parse(Console.ReadLine());

                        courses.Add(new Course(title, creditHours));
                        Course.courseCount++;
                        Console.WriteLine("Course added successfully.");
                        break;
                    case 2:
                        Console.Write("Enter seminar title: ");
                        string seminarTitle = Console.ReadLine();

                        Console.Write("Enter duration (in hours): ");
                        float duration = float.Parse(Console.ReadLine());

                        seminars.Add(new Seminar(seminarTitle, duration));
                        Seminar.seminarCount++;
                        Console.WriteLine("Seminar added successfully.");
                        break;
                    case 3:
                        Console.Write("Enter lab title: ");
                        string labTitle = Console.ReadLine();

                        Console.Write("Enter equipment count: ");
                        int equipmentCount = int.Parse(Console.ReadLine());

                        labs.Add(new Lab(labTitle, equipmentCount));
                        Lab.labCount++;
                        Console.WriteLine("Lab added successfully.");
                        break;
                    case 4:
                        Console.WriteLine("\n--- Course List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (Course course in courses)
                        {
                            Console.WriteLine(course.GetDetails());
                        }

                        Console.WriteLine("\n--- Seminar List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (Seminar seminar in seminars)
                        {
                            Console.WriteLine(seminar.GetDetails());
                        }

                        Console.WriteLine("\n--- Lab List ---");
                        Console.WriteLine("ID \t Type \t Details");
                        foreach (Lab lab in labs)
                        {
                            Console.WriteLine(lab.GetDetails());
                        }

                        Console.WriteLine("\nTotal Courses: " + Course.courseCount);
                        Console.WriteLine("Total Seminars: " + Seminar.seminarCount);
                        Console.WriteLine("Total Labs: " + Lab.labCount);
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
