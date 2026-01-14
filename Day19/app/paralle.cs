using System;
using System.Threading;
using System.Threading.Tasks;

// class Main2
// {
//     public static void main2()
//     {
//         // Parallel.For(0, 5, i =>
//         // {
//         //     Console.WriteLine($"Processing item {i}");
//         // });

// int[] numbers = new int[100];

     
//         for (int i = 0; i < numbers.Length; i++){
//             numbers[i] = i + 1;   
//         }
//         int sum = 0;
//         Parallel.For(0, numbers.Length, i =>
//         {
//             sum += numbers[i];  
//         });

//         Console.WriteLine("Sum: " + sum);
//     }
// }


class Main3
{
    public static void main3()
    {
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++){
            numbers[i] = i + 1;
        }

        int sum = 0;
        Parallel.For(
            0,
            numbers.Length,
            () => 0,                        
            (i, loopState, localSum) =>
            {
                return localSum + numbers[i];
            },
            localSum =>
            {
                Interlocked.Add(ref sum, localSum);   
            });

        Console.WriteLine("Sum: " + sum);
    }
}
