using System;
using System.IO;

class Program
{
    static void Main()
    {

        // code snippet to demonstrate StreamReader and StreamWriter with exception handling
        try
        {
            string input = "input.txt";
            string output = "output.txt";

            if(!File.Exists(input))
            {
                throw new Exception("Input file does not exist!");
            }

            StreamReader sr = new StreamReader(input);
            StreamWriter sw = new StreamWriter(output);

            string content = sr.ReadToEnd();
            sr.Close();

            sw.WriteLine(content.ToUpper());
            sw.Close();

            Console.WriteLine("File processed successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        // code snippet to demonstrate BinaryWriter
        BinaryWriter bw = new BinaryWriter(File.Open("data.bin", FileMode.Create));
        bw.Write(42);
        bw.Close();

        // memory stream example
        MemoryStream ms = new MemoryStream();
        StreamWriter writer = new StreamWriter(ms);
        writer.Write("Hello, MemoryStream!");
        writer.Flush();


        // FileStream example
        // write data
        FileStream fs = new FileStream("example.txt", FileMode.Create);

        byte[] data = System.Text.Encoding.UTF8.GetBytes("hello, stream!");
        fs.Write(data, 0, data.Length);
        fs.Flush();

        fs.Seek(0, SeekOrigin.Begin);
        byte[] buffer = new byte[data.Length];
        int bytesRead = fs.Read(buffer, 0, buffer.Length);
        string readText = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
        Console.WriteLine("Read from file: " + readText);
        fs.Close();

    }
}

