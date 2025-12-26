


using System;
using System.Collections;

// non genric collections -> any data type and run time error


// ArrayList

// Hashtable

// Queue

// Stack

// SortedList





// hashtable -> non genric stored data in key value and output order is not fixed

class Ngen1
{
    public static void ngen1()
    {
        Hashtable table = new Hashtable();

        table.Add(1, "Amit");
        table.Add(2, "Navneet");

        foreach (DictionaryEntry x in table)
        {
            Console.WriteLine(x.Key + " " + x.Value);
        }
    }
}



// Arraylist -> store multiple value and can store differnt data types  and size is dynamic

class Ngen2
{
   public  static void ngen2()
    {
        ArrayList list = new ArrayList();

        list.Add(1);
        list.Add("Hello");
        list.Add(2.5);

        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
    }
}
