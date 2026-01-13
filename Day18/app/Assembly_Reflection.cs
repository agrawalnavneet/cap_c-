using System;
using System.Reflection;

class Main1{
    public static void main1()
    {
        
        // Assembly assembly = Assembly.GetExecutingAssembly();
        // Console.WriteLine("Current Assembly: " + assembly.FullName);

       
        Assembly lib = Assembly.Load("MyLibrary");
        Console.WriteLine("Loaded Assembly: " + lib.FullName);


        // Assembly plugin = Assembly.LoadFrom("MyPlugin.dll");
        // Console.WriteLine("Loaded Plugin: " + plugin.FullName);
    }
}
