using System;
using System.Linq;

// class Main1
// {
    
//     public static void main1()
//     {
        
// //  var student = (1, "Navneet", 22);

// //         Console.WriteLine("Simple Tuple:");
// //         Console.WriteLine(student.Item1); // Id
// //         Console.WriteLine(student.Item2); // Name
// //         Console.WriteLine(student.Item3); // Age
// //         Console.WriteLine();


// // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

// //         var evenNumbers = numbers.Where(n => n % 2 == 0);

// //         Console.WriteLine("Even numbers are:");
// //         foreach (var n in evenNumbers)
// //         {
// //             Console.WriteLine(n);
// //         }


//     }
// }


class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Main1
{
    public static void  main1()
    {
        Student[] students =
        {
            new Student { Name = "Amit", Marks = 70 },
            new Student { Name = "Ravi", Marks = 45 }
        };

        var result = students.Select(s => new
        {
            s.Name,
            Grade = s.Marks > 60 ? "Pass" : "Fail"
        });

        Console.WriteLine(result.GetType());

        foreach (var r in result)
        {
            Console.WriteLine(r.Name + " - " + r.Grade);
        }
    }
}
