using System;
using System.Threading;

class Main1
{
    public static void main1()
    {
        
        Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));

      
        thread.Start("Hello from thread");

        Console.WriteLine("Main thread finished");
    }

    static void PrintMessage(object message)
    {
    
        string msg = (string)message;

        Console.WriteLine(msg);
        
    }
}
