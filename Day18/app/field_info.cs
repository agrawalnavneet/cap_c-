using System;
using System.Reflection;

class Employees
{
    private int salary = 50000;
}

class Main6
{
    public static void main6()
    {
        Employees emp = new Employees();

        Type type = typeof(Employees);

        FieldInfo field = type.GetField("salary",BindingFlags.NonPublic | BindingFlags.Instance);

        int value = (int)field.GetValue(emp);

        Console.WriteLine(value);   
    }
}
