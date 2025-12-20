using System;

// class Fore
// {
//     public static void FOR()
//     {
   
        // int[] numbers = { 10, 20, 30, 40, 50 };
//  string name = "NAVNEET";
        
//         foreach (char nub in letters)
//         {
//             Console.WriteLine("Value: " + nu);
//         }
//     }
// }

    // for string
    //     string name = "NAVNEET";

      
    //     foreach (char c in name)
    //     {
    //         Console.WriteLine(c);
    //     }
    // }
    // }



//  we use Multiple time same type
// class Fore
// {
//     public static int Sum(params int[] numbers)
//     {
//         int total = 0;
//         foreach (int num in numbers)
//         {
//             total += num;}
        
//         return total;
//     }
  
//     public static void FOR()
//     {
//         Console.WriteLine(Sum(1, 2));         
//         Console.WriteLine(Sum(1,2, 3, 4));   
//         Console.WriteLine(Sum(5,10, 15));    
//     }
// }


// paas by ref and value 



class Fore
{

    public static void PassByValue(int x)
    {
        x = x + 10;
        Console.WriteLine("Inside PassByValue: " + x);
    }


    public static void PassByRefer(ref int x)
    {
        x = x + 14;
        Console.WriteLine("Inside PassByReference: " + x);
    }

    // Existing FOR method (can call our examples)
    public static void FOR()
    {
        int a = 5;
        int b = 5;

        Console.WriteLine("Before PassByValue: " + a);
        PassByValue(a);
        Console.WriteLine("After PassByValue: " + a);  

        Console.WriteLine();

        Console.WriteLine("Before PassByReference: " + b);
        PassByRefer(ref b);
        Console.WriteLine("After PassByReference: " + b);  
    }
}

