using System;
using System.Collections.Generic;


// namespace StudentSorting
// {
//     class Student
//     {
//         public string Name { get; set; }
//         public int Age { get; set; }
//         public int Marks { get; set; }
//     }
//     class Custom
//     {
//         public static void custom()
//         {
         
//             List<Student> students = new List<Student>
//             {
//                 new Student { Name = "Navneet", Age = 21, Marks = 85 },
//                 new Student { Name = "Aryan", Age = 20, Marks = 90 },
//                 new Student { Name = "Price", Age = 19, Marks = 90 },
//                 new Student { Name = "Rithik", Age = 22, Marks = 85 }
//             };

           
//             List<Student> sortedStudents = students
//                 .OrderByDescending(s => s.Marks).ThenBy(s => s.Age).ToList();

//             Console.WriteLine("Sorting student:");
//             foreach (var s in sortedStudents)
//             {
//                 Console.WriteLine($"Name: {s.Name}, Age: {s.Age}, Marks: {s.Marks}");
//             }
//         }
//     }

// }





// icompare 




class Student : IComparable<Student>
{
    public int age;
    public string Name;
    public int Marks;


    public int CompareTo(Student other)
    {
        int markc= this.Marks.CompareTo(other.Marks);

        if (markc == 0)
        {
            return this.age.CompareTo(other.age);
        }

        return markc;
    }
}

class Cust
{
    public static void cust()
    {
        List<Student> students = new List<Student>()
        {
            new Student { age = 1, Name = "Aryan", Marks = 70 },
            new Student { age = 2, Name = "Nihal", Marks = 50 },
            new Student { age = 3, Name = "Bansal", Marks = 50 }
        };


        students.Sort();


        foreach (var s in students)
        {
            Console.WriteLine(s.Name + " - " + s.Marks);
        }
    }
}
