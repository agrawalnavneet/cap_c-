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

// pass by ref  modified the value and give updated one
// pass by val  not modifweid is allowed and the value remain same after and before

// class Fore
// {

//     public static void PassByValue(int x)
//     {
//         x = x + 10;
//         Console.WriteLine("Inside PassByVal: " + x);
//     }
//     public static void PassByRefer(ref int x)
//     {
//         x = x + 14;
//         Console.WriteLine("Inside PassByRef: " + x);
//     }
//     public static void FOR()
//     {
//         int a = 5;
//         int b = 5;

//         Console.WriteLine("Before PassByVal: " + a);
//         PassByValue(a);
//         Console.WriteLine("After PassByVal: " + a);  

//         Console.WriteLine();

//         Console.WriteLine("Before PassByRef: " + b);
//         PassByRefer(ref b);
//         Console.WriteLine("After PassByRef " + b);  
//     }
// }



// IN IS  the middleware it take by ref and value one one thing this take
class Fore{
        public static void OutExample(out int result)
    { result = 50;
        result += 10;
        Console.WriteLine("Inside OutExample: " + result);}
    public static void InExample(in int value)
    {
        Console.WriteLine("Inside InExample (readonly): " + value);}
    public static void FOR()
    {
        int x;
        OutExample(out x);
        Console.WriteLine("After OutExample: " + x); // x is initialized and changed by method

        Console.WriteLine();

        int y = 100;
        InExample(in y);
        Console.WriteLine("After InExample: " + y); // y remains unchanged
    }
    
}
