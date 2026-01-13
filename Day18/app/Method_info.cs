using System;
using System.Reflection;

class Employee
{
    public void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Main3
{
    public static void main3()
    {
       
        Employee obj = new Employee();

        Type type = obj.GetType();

    
        MethodInfo method = type.GetMethod("Work");

        method.Invoke(obj, null);
    }
}
