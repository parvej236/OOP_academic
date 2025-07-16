using System;
class Program
{
    static void Main(string[] args)
    {
        // Stream Class Methods
        // 1. FileStream for reading and writing
        FileStream fs = new FileStream("example.txt", FileMode.Create); // Create a new file or overwrite if it exists
        byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, Stream! I am the greatest. \n Hi everyone! 2023!"); // convert string to byte array
        fs.Write(data, 0, data.Length); // write data to the file
        fs.Flush(); // flash to ensure all data is written
        fs.Seek(0, SeekOrigin.Begin); // Move to the beginning of the file for reading

        byte[] buffer = new byte[data.Length]; // buffer to read data
        int bytesRead = fs.Read(buffer, 0, buffer.Length); // read data from the file

        string readText = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead); // convert byte back to string
        Console.WriteLine("Read from file: " + readText); // display the read data
        fs.Close(); // Close the FileStream


        // 2. Byte I/O
        FileStream fsb = new FileStream("binary.txt", FileMode.Create); // Create a new file for binary writing
        fsb.WriteByte((byte)'A'); // Write a single byte
        fsb.WriteByte((byte)'B'); // Write another byte
        fsb.Flush(); // Ensure all data is written to the file
        fsb.Close(); // Close the FileStream


        // 3. Reading from the file
        StreamReader sr = new StreamReader("example.txt"); // Open the file for reading
        // string content = sr.ReadLine();
        string content = sr.ReadToEnd(); // Read the entire file content
        Console.WriteLine("Content of the file: " + content); // Display the content
        sr.Close(); // Close the StreamReader

        // 4. Writing to a file
        StreamWriter sw = new StreamWriter("output.txt"); // Open a file for writing
        sw.WriteLine("This is a line written to the file."); // Write a line to the file
        sw.Flush(); // Ensure all data is written to the file
        sw.Close(); // Close the StreamWriter

        // 5. BinaryReader & BinaryWriter
        BinaryWriter bw = new BinaryWriter(File.Open("file.bin", FileMode.Create)); // Create a BinaryWriter to write binary data
        bw.Write(42); // Write an integer
        bw.Write("Hello, Binary!"); // Write a string
        bw.Flush(); // Ensure all data is written to the file
        bw.Close(); // Close the BinaryWriter

        BinaryReader br = new BinaryReader(File.Open("file.bin", FileMode.Open)); // Create a BinaryReader to read binary data
        int number = br.ReadInt32(); // Read an integer
        string message = br.ReadString(); // Read a string
        Console.WriteLine("Read from binary file: " + number + ", " + message); // Display the read data
        br.Close(); // Close the BinaryReader

        // 6. MemoryStream (Temporary In-Memory I/O)
        MemoryStream ms = new MemoryStream(); // Create a new MemoryStream
        StreamWriter mw = new StreamWriter(ms); // Create a StreamWriter for the MemoryStream
        mw.WriteLine("This is written to memory."); // Write a line to the MemoryStream
        mw.Flush(); // Ensure data is written to the MemoryStream
        ms.Seek(0, SeekOrigin.Begin); // Move to the beginning of the MemoryStream
        mw.Close(); // Close the StreamWriter

        StreamReader mr = new StreamReader(ms); // Create a StreamReader for the MemoryStream
        string memoryContent = mr.ReadToEnd(); // Read the entire content of the MemoryStream
        Console.WriteLine("Content of MemoryStream: " + memoryContent); // Display the content
        mr.Close(); // Close the StreamReader
    }
}