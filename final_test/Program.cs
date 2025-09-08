using System;
using System.Collections.Generic;
abstract class Animal
{
   public int ID { get; set; }
   public abstract string Type { get; }
   public abstract string GetInfo();
}
class Cow : Animal
{
    public float DailyMilk { get; set; }
   public override string Type
   {
       get { return "Cow"; }
   }
   public Cow(int id, float dailyMilk)
   {
       ID = id;
       DailyMilk = dailyMilk;
   }
   public override string GetInfo()
   {
       return "Milk/day: " + DailyMilk + " L";
   }
}
class Chicken : Animal
{
   public int EggsPerDay { get; set; }
   public override string Type
   {
       get { return "Chicken"; }
   }
   public Chicken(int id, int eggs)
   {
       ID = id;
       EggsPerDay = eggs;
   }
   public override string GetInfo()
   {
       return "Eggs/day: " + EggsPerDay;
   }
}
class Sheep : Animal
{
   public float WoolPerMonth { get; set; }
   public override string Type
   {
       get { return "Sheep"; }
   }
   public Sheep(int id, float wool)
   {
       ID = id;
       WoolPerMonth = wool;
   }
   public override string GetInfo()
   {
       return "Wool/month: " + WoolPerMonth + " kg";
   }
}
class Program
{
   static List<Animal> animals = new List<Animal>();
   static int nextId = 1;
   static void Main()
   {
       while (true)
       {
           Console.WriteLine("\n--- Virtual Farm Animal Tracker ---");
           Console.WriteLine("1. Add Cow");
           Console.WriteLine("2. Add Chicken");
           Console.WriteLine("3. Add Sheep");
           Console.WriteLine("4. List Animals");
           Console.WriteLine("5. Search Animal by ID");
           Console.WriteLine("6. Delete Animal by ID");
           Console.WriteLine("7. Get Statistics");
           Console.WriteLine("8. Exit");
           Console.Write("Choose an option: ");
           string choice = Console.ReadLine();

           switch (choice)
           {
               case "1":
                   AddCow();
                   break;
               case "2":
                   AddChicken();
                   break;
               case "3":
                   AddSheep();
                   break;
               case "4":
                   ListAnimals();
                   break;
               case "5":
                   SearchAnimal();
                   break;
               case "6":
                   DeleteAnimal();
                   break;
               case "7":
                   ShowStatistics();
                   break;
               case "8":
                   return;
               default:
                   Console.WriteLine("Invalid option. Try again.");
                   break;
           }
       }
   }

   static void AddCow()
   {
       if (animals.Count >= 100)
       {
           Console.WriteLine("Farm is full!");
           return;
       }
       Console.Write("Enter milk per day (L): ");
       if (float.TryParse(Console.ReadLine(), out float milk))
       {
           Cow cow = new Cow(nextId++, milk);
           animals.Add(cow);
           Console.WriteLine("Cow added successfully.");
       }
       else
       {
           Console.WriteLine("Invalid input.");
       }
   }
   static void AddChicken()
   {
       if (animals.Count >= 100)
       {
           Console.WriteLine("Farm is full!");
           return;
       }
       Console.Write("Enter eggs per day: ");
       if (int.TryParse(Console.ReadLine(), out int eggs))
       {
           Chicken chicken = new Chicken(nextId++, eggs);
           animals.Add(chicken);
           Console.WriteLine("Chicken added successfully.");
       }
       else
       {
           Console.WriteLine("Invalid input.");
       }
   }
   static void AddSheep()
   {
       if (animals.Count >= 100)
       {
           Console.WriteLine("Farm is full!");
           return;
       }
       Console.Write("Enter wool per month (kg): ");
       if (float.TryParse(Console.ReadLine(), out float wool))
       {
           Sheep sheep = new Sheep(nextId++, wool);
           animals.Add(sheep);
           Console.WriteLine("Sheep added successfully.");
       }
       else
       {
           Console.WriteLine("Invalid input.");
       }
   }
   static void ListAnimals()
   {
       if (animals.Count <= 0)
       {
           Console.WriteLine("No animal added yet!");
           return;
       }
       Console.WriteLine("\nID\tType\t\tInfo");
       Console.WriteLine("=====================================");


       foreach (Animal animal in animals)
       {
           Console.WriteLine($"{animal.ID}\t{animal.Type}\t{animal.GetInfo()}");
       }
   }
   static void SearchAnimal()
   {
       Console.Write("Enter ID to search: ");
       if (int.TryParse(Console.ReadLine(), out int id))
       {
           Animal found = null;
           foreach (Animal animal in animals)
           {
               if (animal.ID == id)
               {
                   found = animal;
                   break;
               }
           }
           if (found != null)
           {
               Console.WriteLine("Found:");
               Console.WriteLine($"ID: {found.ID}\nType: {found.Type}\n{found.GetInfo()}");
           }
           else
           {
               Console.WriteLine("Animal not found.");
           }
       }
   }
   static void DeleteAnimal()
   {
       Console.Write("Enter ID to delete: ");
       if (int.TryParse(Console.ReadLine(), out int id))
       {
           Animal found = null;
           foreach (Animal animal in animals)
           {
               if (animal.ID == id)
               {
                   found = animal;
                   break;
               }
           }
           if (found != null)
           {
               animals.Remove(found);
               Console.WriteLine("Animal deleted successfully.");
           }
           else
           {
               Console.WriteLine("Animal not found.");
           }
       }
   }
   static void ShowStatistics()
   {
       int cowCount = 0, chickenCount = 0, sheepCount = 0;
       float totalMilk = 0, totalWool = 0;
       int totalEggs = 0;
       foreach (var animal in animals)
       {
           if (animal is Cow cow)
           {
               cowCount++;
               totalMilk += cow.DailyMilk;
           }
           else if (animal is Chicken chicken)
           {
               chickenCount++;
               totalEggs += chicken.EggsPerDay;
           }
           else if (animal is Sheep sheep)
           {
               sheepCount++;
               totalWool += sheep.WoolPerMonth;
           }
       }
       int totalAnimals = animals.Count;
       Console.WriteLine("\n--- Farm Statistics ---");
       Console.WriteLine($"Total Animals: {totalAnimals}");
       Console.WriteLine($"Cows: {cowCount}");
       Console.WriteLine($"Chickens: {chickenCount}");
       Console.WriteLine($"Sheep: {sheepCount}\n");
       Console.WriteLine($"Total Milk/Day: {totalMilk} L");
       Console.WriteLine($"Total Eggs/Day: {totalEggs}");
       Console.WriteLine($"Total Wool/Month: {totalWool} kg\n");
       if (totalAnimals > 0)
       {
           Console.WriteLine($"Cows: {cowCount * 100.0 / totalAnimals:F2}%");
           Console.WriteLine($"Chickens: {chickenCount * 100.0 / totalAnimals:F2}%");
           Console.WriteLine($"Sheep: {sheepCount * 100.0 / totalAnimals:F2}%");
       }
   }
}