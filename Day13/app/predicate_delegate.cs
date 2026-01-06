using System;



// prdicate always give boolean value
class Main5()
{
    public static void main5()
    {
        Predicate<int> isEligible= age=> age>=18;
Console.WriteLine(isEligible(20));

    }
}