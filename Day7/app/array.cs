using System;

// class Arr
// {
//     public static void arr()

//     {
//         int [] num= {10,20,30,40};
//         foreach(int i in num){
//             Console.Write(i+",");
//         }

//     }
// }


//2d

class Arr
{
    public static void arrr()
    {
        int[,] arr2 = new int[,]
        {
            { 1, 2, 3 },
            { 4, 5, 8 }
        };
        Console.WriteLine(arr2[0,2]);
    }
}


class Arr2
{
    public static void arrr2()
    {
        int[,]ar3=new int[,]
        {
            {1,4,5},
            {2,3,4}
        };
        for(int i = 0; i < ar3.GetLength(0); i++)
        {
            for (int j = 0; j < ar3.GetLength(1); j++)
            {
                Console.Write(ar3[i,j]+"");
            }
            Console.WriteLine();
        }
    }
}


class Arr3
{
    public static void arrr3()
    {
        int[][] jagged = new int[2][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 4, 3, 5 };

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                Console.Write(jagged[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
