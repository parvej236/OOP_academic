using System;
class Program
{
    public static void BubbleSort(List<int> id, List<float> cgpa)
    {
        for (int i = 0; i < cgpa.Count - 1; i++)
        {
            for (int j = 0; j < cgpa.Count - i - 1; j++)
            {
                if (cgpa[j] < cgpa[j + 1])
                {
                    (cgpa[j], cgpa[j + 1]) = (cgpa[j + 1], cgpa[j]); 
                    (id[j], id[j + 1]) = (id[j + 1], id[j]);
                }
            }
        }
    }
    public static void Main()
    {
        for (int i = 10; i < 21; i++) {
            StreamReader file = new StreamReader($"Batch{i}.txt");
            var id = new List<int>();
            var cgpa = new List<float>();

            while (true)
            {
                string? input = file.ReadLine();
                if (input == null) break;
                string[] pair = input.Split(" ");
                id.Add(int.Parse(pair[0]));
                cgpa.Add(float.Parse(pair[1]));
            }

            BubbleSort(id, cgpa);

            file.Close();

            StreamWriter output = new StreamWriter($"output{i}.txt", false);

            for (int j = 0; j < id.Count; j++)
            {
                output.WriteLine($"{id[j]} {cgpa[j]:F1}");
            }
            output.Close();
        }
    }
}
