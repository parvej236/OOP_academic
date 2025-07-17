using System;

namespace UniversityCourseManagementSystem
{
    public class Course
    {
        private int id;
        private string title;
        private int creditHours;
        public static int courseCount = 0;
        public Course(int courseId, string title, int creditHours)
        {
            id = courseId;
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
        private int id;
        private string title;
        private float duration;
        public static int seminarCount = 0;

        public Seminar(int seminarId, string title, float duration)
        {
            id = seminarId;
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
        private int id;
        private string title;
        private int equipmentCount;
        public static int labCount = 0;

        public Lab(int labId, string title, int equipmentCount)
        {
            id = labId;
            this.title = title;
            this.equipmentCount = equipmentCount;
        }

        public string GetDetails()
        {
            return $"{id} \t Lab \t\t Title: \"{title}\", Equipment: {equipmentCount}";
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {

            List<Course> courses = new List<Course>();
            List<Seminar> seminars = new List<Seminar>();
            List<Lab> labs = new List<Lab>();

            int courseId = 1;
            int seminarId = 1;
            int labId = 1;

            while (true)
            {
                Console.WriteLine("\nUniversity Course Management System Menu:");
                Console.WriteLine("1. Add a Course");
                Console.WriteLine("2. Add a Seminar");
                Console.WriteLine("3. Add a Lab");
                Console.WriteLine("4. List Subjects");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int choice;

                if(!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }                

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter course title: ");
                        
                        string title = Console.ReadLine()?.Trim();

                        while (string.IsNullOrEmpty(title))
                        {
                            Console.Write("Title cannot be empty. Please enter a valid title: ");
                            title = Console.ReadLine()?.Trim();
                        }

                        Console.Write("Enter credit hours: ");
                        int creditHours;
                        while (!int.TryParse(Console.ReadLine(), out creditHours) || creditHours <= 0)
                        {
                            Console.Write("Invalid input. Credit hours must be a positive number. Please enter again: ");
                        }

                        courses.Add(new Course(courseId++ ,title, creditHours));
                        Course.courseCount++;
                        Console.WriteLine("Course added successfully.");
                        break;
                    case 2:
                        Console.Write("Enter seminar title: ");
                        string seminarTitle = Console.ReadLine();

                        while (string.IsNullOrEmpty(seminarTitle))
                        {
                            Console.Write("Title cannot be empty. Please enter a valid title: ");
                            seminarTitle = Console.ReadLine()?.Trim();
                        }

                        Console.Write("Enter duration (in hours): ");
                        float duration;
                        while (!float.TryParse(Console.ReadLine(), out duration) || duration <= 0)
                        {
                            Console.Write("Invalid input. Duration must be a positive number. Please enter again: ");
                        }

                        seminars.Add(new Seminar(seminarId++, seminarTitle, duration));
                        Seminar.seminarCount++;
                        Console.WriteLine("Seminar added successfully.");
                        break;
                    case 3:
                        Console.Write("Enter lab title: ");
                        string labTitle = Console.ReadLine();

                        while (string.IsNullOrEmpty(labTitle))
                        {
                            Console.Write("Title cannot be empty. Please enter a valid title: ");
                            labTitle = Console.ReadLine()?.Trim();
                        }

                        Console.Write("Enter equipment count: ");
                        int equipmentCount;
                        while (!int.TryParse(Console.ReadLine(), out equipmentCount) || equipmentCount <= 0)
                        {
                            Console.Write("Invalid input. Equipment count must be a positive number. Please enter again: ");
                        }

                        labs.Add(new Lab(labId++, labTitle, equipmentCount));
                        Lab.labCount++;
                        Console.WriteLine("Lab added successfully.");
                        break;
                    case 4:
                        Console.WriteLine("\n--- Course List ---");
                        Console.WriteLine("ID \t Type \t\t Details");
                        foreach (Course course in courses)
                        {
                            Console.WriteLine(course.GetDetails());
                        }

                        Console.WriteLine("\n--- Seminar List ---");
                        Console.WriteLine("ID \t Type \t\t Details");
                        foreach (Seminar seminar in seminars)
                        {
                            Console.WriteLine(seminar.GetDetails());
                        }

                        Console.WriteLine("\n--- Lab List ---");
                        Console.WriteLine("ID \t Type \t\t Details");
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
