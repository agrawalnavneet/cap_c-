using System;
using System.IO;

class   Main1
{
   public  static void main1()
    {
        
        using (StreamWriter writer = new StreamWriter("log.txt"))
        {
            writer.WriteLine("Application Started");
            writer.WriteLine("Processing Data");
            writer.WriteLine("Application Ended");
        }

    
        using (StreamReader reader = new StreamReader("log.txt"))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}
