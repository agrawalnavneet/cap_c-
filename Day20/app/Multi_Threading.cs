using System;
using System.Diagnostics;
class Main1
{
    public static void main1()
    {
        Process currentprocess= Process.GetCurrentProcess();
        Console.WriteLine("Current Process ID: " + currentprocess.Id);
        Console.WriteLine("Process Name: "+ currentprocess.ProcessName);
                Console.WriteLine("Process Time: "+ currentprocess.TotalProcessorTime);
    }
}