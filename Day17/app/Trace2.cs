using System;
using System.Diagnostics;

class Main2
{
    public static void main2()
    {
        Trace.Listeners.Add(new ConsoleTraceListener());

        Trace.WriteLine("Program started");

        PerformCalculation(10, 5);
        PerformCalculation(10, 0);   // Error case

        Trace.WriteLine("Program ended");
    }

    static void PerformCalculation(int a, int b)
    {
        Trace.WriteLine($"Entering PerformCalculation | a={a}, b={b}");

        try
        {
            int result = Divide(a, b);
            Trace.WriteLine($"Calculation successful | Result = {result}");
        }
        catch (Exception ex)
        {
            Trace.WriteLine("Exception occurred: " + ex.Message);
        }

        Trace.WriteLine("Exiting PerformCalculation");
    }

    static int Divide(int x, int y)
    {
        Trace.WriteLine($"Dividing values | x={x}, y={y}");
        return x / y;
    }
}
