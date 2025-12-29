// using System;
// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating");
//     }
// }
// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking");
//     }
// }
// class inheri
// {
//     public static void inherit()
//     {
//         Dog d = new Dog();

//         d.Eat();   
//         d.Bark();  
//     }
// }






using System;
interface IPrintable
{
    void Print();
}
interface IScannable
{
    void Scan();
}

//  implementing multiple interfaces
class Machine : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }
    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}

class inheri
{
    public static void inherit()
    {
        Machine m = new Machine();
        m.Print();
        m.Scan();
    }
}
