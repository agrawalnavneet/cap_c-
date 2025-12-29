using System;
using System.IO;

class Main3
{
    public static void main3()
    {
        FileStream file = null;

        try
        {
            file = new FileStream("data.txt", FileMode.Open);
            
            // Perform file operation
            int data = file.ReadByte();
            Console.WriteLine("First byte read: " + data);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        finally
        {
            if (file != null)
            {
                file.Close(); // Ensures file is always closed
                Console.WriteLine("File stream closed in finally block.");
            }
        }
    }
}
