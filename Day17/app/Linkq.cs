using System;
using System.Collections.Generic;
using System.Linq;

// class Student
// {
//     public string Name { get; set; }
//     public int Marks { get; set; }
// }

// class Main4
// {
//     public static void main4()
//     {
//         List<Student> students = new List<Student>()
//         {
//             new Student { Name = "Rahul", Marks = 70 },
//             new Student { Name = "Amit", Marks = 50 },
//             new Student { Name = "Neha", Marks = 80 }
//         };

//         var result = students.Select(s => new
//         {
//             s.Name,
//             Grade = s.Marks > 60 ? "Pass" : "Fail"
//         });

//         foreach (var s in result)
//         {
//             Console.WriteLine(s.Name + " - " + s.Grade);

//         }
//         Console.WriteLine(result.GetType());
//     }
// }

// sorting
class Employee
{
    public string Name { get; set; }
    public int Salary{ get; set; }
}

class Main4
{
    public static void main4()
    {
        List< Employee> employees = new List< Employee>()
        {
            new  Employee{ Name = "Rahul", Salary = 70 },
            new  Employee { Name = "Amit", Salary  = 50 },
            new  Employee{ Name = "Neha",Salary  = 80 }
        };

       var sortedBySalary= employees.OrderBy(e=>e.Salary);
    //    var sortedBySalary= employees.OrderBy(e=>e.Name);

        foreach (var s in sortedBySalary)
        {
            Console.WriteLine(s.Name + " - " + s.Salary);

        }
        Console.WriteLine(sortedBySalary.GetType());
    }
}
