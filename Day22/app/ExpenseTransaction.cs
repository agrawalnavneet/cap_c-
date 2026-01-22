using System;

interface Int1
{
    void A();
    void B();
}

interface Int2
{
    void C();
}

interface Int3
{
    void D();
}

class Abc : Int1, Int2, Int3
{
    public void A()
    {
        Console.WriteLine("A");
    }
    public void B()
    {
        Console.WriteLine("B");
    }
    public void C()
    {
        Console.WriteLine("C");
    }
    public void D()
    {
        Console.WriteLine("D");
    }
}

class Main1
{
    public static void main1()
    {
        Abc abc = new Abc();
        abc.A();
        abc.B();
        abc.C();
    }
}