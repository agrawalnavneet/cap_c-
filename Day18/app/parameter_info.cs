using System;
using System.Reflection;

class Calculator
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
}

class Main9
{
    public static void main9()
    {
      
        Type type = typeof(Calculator);

        
        MethodInfo method = type.GetMethod("Add");

       
        ParameterInfo[] parameters = method.GetParameters();

        Console.WriteLine("Method Name: " + method.Name);
        Console.WriteLine("Parameters:");

        foreach (ParameterInfo p in parameters)
        {
            Console.WriteLine("Name: " + p.Name + ", Type: " + p.ParameterType);
        }
    }
}
