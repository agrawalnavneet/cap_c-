using System;

using System.Collections.Generic;


// Generic Collections-> fixed data type and  compile time error

// List<T>

// Dictionary<TKey, TValue>

// Queue<T>

// Stack<T>

// HashSet<T>

// SortedList<TKey, TValue>

// SortedDictionary<TKey, TValue>






// list  multiple value can store and  do not fix valuev at start  we can add or remove at any time
class coll
{
    public static void Coll()
    {

        List<int> num= new List<int>();
num.Add(2);
num.Add(3);
foreach(int n in num)
Console.WriteLine(n);
// Console.WriteLine(num[0]);
        
    }
}




// stack ->Lifo
class Sys1
{
    public static void sys1()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Console.WriteLine(stack.Pop()); 
        // Console.WriteLine(stack.Pop()); 
        Console.WriteLine(stack.Peek()); 
        Console.WriteLine(stack.Peek()); 

    }
}

// queue ->Fifo

class Sys2
{
    public static void sys2()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        // Console.WriteLine(queue.Dequeue()); 
        //      Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Peek());    
        Console.WriteLine(queue.Peek());    
    }
}




// dictionry -> key value 

class Sys3
{
    public static void sys3()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Navneet");
        students.Add(2, "Ravi");

        foreach (var s in students)
        {
            Console.WriteLine(s.Key + " " + s.Value);
        }
    }
}



//Hashset -> unique value no duplicay allowed

class Sys4
{
   public  static void sys4()
    {
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(4);
        set.Add(4); // duplicate

        foreach (int x in set)
        {
            Console.WriteLine(x);
        }
    }
}




// sorted list   ->  store data in key value and autmaticaly  data sorted by key
class Sys5
{
    public static void sys5()
    {
        SortedList<int, string> list = new SortedList<int, string>();

        list.Add(3, "Three");
        list.Add(1, "One");
        list.Add(2, "Two");

        foreach (var x in list)
        {
            Console.WriteLine(x.Key + " " + x.Value);
        }
    }
}
