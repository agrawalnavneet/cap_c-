using System;



// action delegate
class Main3
{
    public static void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }
    public static void main3()
    {
        Action<string> a = PrintMessage;
        a("Hello Navneet");
    }
}