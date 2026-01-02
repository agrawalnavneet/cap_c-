using System;

class Main1
{
    public static void main1()
    {
        
//  var student = (1, "Navneet", 22);

//         Console.WriteLine("Simple Tuple:");
//         Console.WriteLine(student.Item1); // Id
//         Console.WriteLine(student.Item2); // Name
//         Console.WriteLine(student.Item3); // Age
//         Console.WriteLine();


int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers are:");
        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);
        }
    }
}