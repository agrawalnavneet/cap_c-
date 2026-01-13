using System;
using System.Collections.Generic;
using System.Linq;

class Main5
{
   public  static void main5()
    {
        //  Single()
        List<int> numbers1 = new List<int> { 3 };

        int value = numbers1.Single();
        Console.WriteLine("Single(): " + value);

        //  Single(predicate)
        List<int> numbers2 = new List<int> { 1, 2, 3 };

        int result = numbers2.Single(n => n == 3);
        Console.WriteLine("Single(predicate): " + result);
    }
}
