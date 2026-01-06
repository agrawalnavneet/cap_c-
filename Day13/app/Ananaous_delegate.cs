using System;


// ananonmous deleagtee
delegate void ErrorDelegate(string message);
class Main6
{
    public static void main6()
    {
        ErrorDelegate errorHandler= delegate(string msg)
        {
            Console.WriteLine("Error: "+msg);

        };
        errorHandler("file not found");
    }
}