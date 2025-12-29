using System;
using System.Collections.Generic;

class Gen
{
    public static void gen()
    {
       
        List<double> prices = new List<double>();
        prices.Add(99.99);
        prices.Add(149.50);
        Console.WriteLine("Prices:");
        foreach (double price in prices)
        {
            Console.WriteLine(price);
        }
    }
}
