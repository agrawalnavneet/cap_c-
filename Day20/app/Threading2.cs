using System;
using System.Threading;

class Main2
{
    public static void main2()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();   
        t2.Start();   

        t1.Join();  
        t2.Join();

        Console.WriteLine("Final Count = " + count);
    }

static object lockObj=new object();

     static int count = 0;

    static void Increment()
    {
        for (int i = 0; i < 1000000; i++)
        {
           lock (lockObj);
        
      

        {
            count++;
            // Console.WriteLine($"Count: {count} from thread {Thread.CurrentThread.ManagedThreadId}");
            // Thread.Sleep(100);
        }
    }
}
}