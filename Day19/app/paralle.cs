using System;
using System.Threading.Tasks;

class Main2
{
    public static void main2()
    {
        Parallel.For(0, 5, i =>
        {
            Console.WriteLine($"Processing item {i}");
        });
    }
}
