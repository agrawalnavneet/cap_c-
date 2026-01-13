using System;
using System.Reflection;

class Person
{
    public string Name { get; set; }
}

class Main5
{
    public static void main5()
    {
        
        Person obj = new Person();

        //  Get Type
        Type type = typeof(Person);

        PropertyInfo prop = type.GetProperty("Name");
        prop.SetValue(obj, "John");

     
        Console.WriteLine(obj.Name);  
    }
}
