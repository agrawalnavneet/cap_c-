using System;

namespace MyApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Main2
    {
        public static void main2()
        {
            Type t1 = typeof(Employee);
            Console.WriteLine("typeof: " + t1.FullName);

            Employee emp = new Employee();

            Type t2 = emp.GetType();
            Console.WriteLine("GetType(): " + t2.FullName);

            Type t3 = Type.GetType("MyApp.Models.Employee");
            
            Console.WriteLine("Type.GetType(): " + t3?.FullName);
        }
    }
}

