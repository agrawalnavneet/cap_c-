using System;



//Array.Clear -> clear values and set to 0 or null
class Met1
{
    public static void met1()
    {
        int[] arr = { 1, 2, 3, 4 };
        Array.Clear(arr, 1, 3);

        foreach (int x in arr)
        {
            Console.WriteLine(x);
        }
    }
}


// Array.Copy-> copy value from one array to another


class Met2
{
    public static void met2()
    {
        int[] src = { 1, 2, 3 };
int[] dest = new int[3];

Array.Copy(src, dest, 2);


        foreach (int x in dest)
        {
            Console.WriteLine(x);
        }
    }
}


// Array.Reverse->. Reverse the array

class Met3
{
    public static void met3()
    {
      int[] arr = { 1, 2, 3 };
Array.Reverse(arr);

        foreach (int x in arr)
        {
            Console.WriteLine(x);
        }
    }
}


// Array.IndexOf -> find the index value 

class Met4
{
    public static void met4()
    {
       int[] arr = { 10, 20, 30 };
int index = Array.IndexOf(arr, 20);

Console.WriteLine(index);

    
    }
}


// Array.Exists() -> check  the codition exits or not give in form of true and false

class Met5
{
    public static void met5()
    {
       int[] arr = { 5, 10, 15 };

bool found = Array.Exists(arr, x => x > 16);
Console.WriteLine(found);

    }
}

// Array.Sort() -> sort the array in asscending order

class Met6
{
    public static void met6()
    {
        int[] arr = { 5, 2, 9, 1,0 };
Array.Sort(arr);

foreach (int x in arr)
    Console.WriteLine(x);

    }
}

// Array.Resize() -> change the size of the array


class Met7
{
    public static void met7()
    {
        int[] arr = { 1, 2, 3 };

        Array.Resize(ref arr, 5);

        arr[3] = 4;
        arr[4] = 5;

        foreach (int x in arr)
        {
            Console.WriteLine(x);
        }
    }
}

