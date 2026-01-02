using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

class Main3
{
    public static void main3()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Amit", Salary = 50000 },
            new Employee { Name = "Ravi", Salary = 70000 },
            new Employee { Name = "Neha", Salary = 60000 }
        };

        var sortedBySalary = employees.OrderBy(e => e.Salary);

        foreach (var e in sortedBySalary)
        {
            Console.WriteLine(e.Name + " - " + e.Salary);
        }
    }
}
