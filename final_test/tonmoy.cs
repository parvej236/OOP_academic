// using System;
// abstract class Animal
// {
//     public static int count = 0, nowid = 1;
//     private int id;
//     private string type;
//     public string Type
//     {
//         get { return type; }
//     }
//     public int Id
//     {
//         get { return id; }
//     }
//     public Animal(string type)
//     {
//         id = nowid;
//         nowid++;
//         count++;
//         this.type = type;
//     }

//     public abstract string Getinfo();
// }
// class Cow : Animal
// {
//     private float milkperday;
//     public static int cowcnt = 0;
//     public static float tmpd = 0;
//     public float Milkperday
//     {
//         get { return milkperday; }
//     }

//     public Cow(float milkperday) : base("Cow")
//     {
//         cowcnt++;
//         tmpd += milkperday;
//         this.milkperday = milkperday;

//     }
//     public override string Getinfo()
//     {
//         return "Cow       " + (milkperday);
//     }
// }


// class Chicken : Animal
// {
//     private int eggsperday;
//     public static int chickencnt = 0;
//     public static int tepd = 0;
//     public int Eggsperday
//     {
//         get { return eggsperday; }
//     }


//     public Chicken(int eggsperday) : base("Chicken")
//     {
//         chickencnt++; tepd += eggsperday;
//         this.eggsperday = eggsperday;
//     }
//     public override string Getinfo()
//     {
//         return "Chicken    " + eggsperday;
//     }
// }
// class Sheep : Animal
// {
//     private float woolpermonth;
//     public static int sheepcnt = 0;
//     public static float twpm = 0;
//     public float Woolpermonth
//     {
//         get { return woolpermonth; }
//     }
//     public Sheep(float woolpermonth) : base("Sheep")
//     {
//         sheepcnt++;
//         twpm += woolpermonth;
//         this.woolpermonth = woolpermonth;
//     }
//     public override string Getinfo()
//     {
//         return "Sheep      " + woolpermonth;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Animal[] animals = new Animal[100];

//         while (true)
//         {
//             Console.WriteLine("\nMenu: ");
//             Console.WriteLine("1.Add Cow");
//             Console.WriteLine("2.Add Chicken");
//             Console.WriteLine("3.Add Sheep");
//             Console.WriteLine("4.List Animals");
//             Console.WriteLine("5.Search Animal by ID");
//             Console.WriteLine("6.Delete Animal by ID");
//             Console.WriteLine("7.Get Statistics");
//             Console.WriteLine("8.Exit");
//             Console.Write("Choose an Option: ");
//             int option = Convert.ToInt32(Console.ReadLine());
//             if (option == 1)
//             {
//                 Console.Write("Enter Milk/Day: ");
//                 float milkperday = Convert.ToSingle(Console.ReadLine());
//                 int count = Animal.count;
//                 animals[count] = new Cow(milkperday);
//             }
//             else if (option == 2)
//             {
//                 Console.Write("Enter Eggs/Day: ");
//                 int eggsperday = Convert.ToInt32(Console.ReadLine());
//                 int count = Animal.count;
//                 animals[count] = new Chicken(eggsperday);
//             }
//             else if (option == 3)
//             {
//                 Console.Write("Enter Wool/Month: ");
//                 float woolpermonth = Convert.ToSingle(Console.ReadLine());
//                 int count = Animal.count;
//                 animals[count] = new Sheep(woolpermonth);
//             }
//             else if (option == 4)
//             {
//                 Console.WriteLine("ID    Type      Info");
//                 Console.WriteLine("==========================");
//                 for (int i = 0; i < Animal.count; i++)
//                 {
//                     Console.WriteLine(animals[i].Id + "      " + animals[i].Getinfo());
//                 }
//             }

//             else if (option == 5)
//             {
//                 Console.Write("Enter ID to search: ");
//                 int id = Convert.ToInt32(Console.ReadLine());
//                 bool found = false;
//                 for (int i = 0; i < Animal.count; i++)
//                 {
//                     if (animals[i].Id == id)
//                     {
//                         Console.WriteLine("Found:");
//                         Console.WriteLine("ID: " + animals[i].Id);
//                         Console.WriteLine("Type: " + animals[i].Type);
//                         if (animals[i].Type == "Cow")
//                         {
//                             Console.WriteLine("Milk/Day:" + ((Cow)animals[i]).Milkperday);
//                         }
//                         else if (animals[i].Type == "Chicken")
//                         {
//                             Console.WriteLine("Eggs/Day:" + ((Chicken)animals[i]).Eggsperday);
//                         }
//                         else if (animals[i].Type == "Sheep")
//                         {
//                             Console.WriteLine("Woll/Month:" + ((Sheep)animals[i]).Woolpermonth);
//                         }
//                         found = true;
//                         break;
//                     }
//                 }
//                 if (found == false)
//                 {
//                     Console.WriteLine("not found");
//                 }
//             }
//             else if (option == 6)
//             {
//                 Console.Write("Enter ID: ");
//                 int id = Convert.ToInt32(Console.ReadLine());
//                 int idx = -1;
//                 for (int i = 0; i < Animal.count; i++)
//                 {
//                     if (animals[i].Id == id)
//                     {
//                         idx = i; break;
//                     }
//                 }

//                 if (idx == -1)
//                 {
//                     Console.WriteLine("Error: not found");
//                 }
//                 else
//                 {
//                     if (animals[idx].Type == "Cow")
//                     {
//                         Cow.cowcnt--;
//                         Cow.tmpd -= ((Cow)animals[idx]).Milkperday;


//                     }
//                     else if (animals[idx].Type == "Sheep")
//                     {
//                         Sheep.sheepcnt--;
//                         Sheep.twpm -= ((Sheep)animals[idx]).Woolpermonth;


//                     }
//                     else
//                     {
//                         Chicken.chickencnt--;
//                         Chicken.tepd -= ((Chicken)animals[idx]).Eggsperday;
//                     }
//                     for (int i = idx; i < Animal.count - 1; i++)
//                     {
//                         animals[i] = animals[i + 1];
//                     }
//                     Animal.count--;
//                     Console.WriteLine("Deleted animal successfully");
//                 }
//             }
//             else if (option == 7)
//             {
//                 Console.WriteLine("Total Animals: " + Animal.count);
//                 Console.WriteLine("Cows: " + Cow.cowcnt);
//                 Console.WriteLine("Chicken: " + Chicken.chickencnt);
//                 Console.WriteLine("Sheep: " + Sheep.sheepcnt + "\n");
//                 Console.WriteLine("Total Milk/Day: " + Cow.tmpd + " L");
//                 Console.WriteLine("Total Eggs/Day: " + Chicken.tepd);
//                 Console.WriteLine("Total Wool/Month: " + Sheep.twpm);
//                 Console.WriteLine("Cows: " + (float)Cow.cowcnt / Animal.count * 100 + "%");
//                 Console.WriteLine("Chickens: " + (float)Chicken.chickencnt / Animal.count * 100 + "%");
//                 Console.WriteLine("Sheeps: " + (float)Sheep.sheepcnt / Animal.count * 100 + "%");
//             }
//             else
//             {
//                 Console.WriteLine("Exiting...");
//                 break;
//             }
//         }
//     }
// }
