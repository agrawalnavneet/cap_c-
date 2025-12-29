using System;

// class Fun
// {
//     public static void fun()
//     {
//         int[] src = { 1, 2, 3 };
//         int[] dest = new int[3];

//         Array.Copy(src, dest, 2);
// Array.Copy(src, dest, 0);

//         for (int i = 0; i < dest.Length; i++)
//         {
//             Console.Write(dest[i] + " ");
//         }
//     }
// }


using System;

class Fun2
{
    public static void fun2()
    {
        int[] src = { 1, 2  };

        bool found = Array.Exists(src, x => x > 2);

        Console.WriteLine(found);
    }
}
