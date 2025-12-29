using System;
using System.Collections;
using System.Collections.Generic;

class Main4
{
    public static void main4()
    {
        Console.WriteLine("TASK 1: DYNAMIC PRODUCT PRICE ANALYSIS");

        Console.Write("Enter number of products: ");
        int productCount = int.Parse(Console.ReadLine());

        int[] prices = new int[productCount];
        int sum = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            int price;
            do
            {
                Console.Write($"Enter price for product {i}: ");
                price = int.Parse(Console.ReadLine());
            } while (price <= 0);

            prices[i] = price;
            sum += price;
        }

        double averagePrice = (double)sum / prices.Length;

        Array.Sort(prices);

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < averagePrice)
                prices[i] = 0;
        }

        int oldLength = prices.Length;
        Array.Resize(ref prices, oldLength + 5);

        for (int i = oldLength; i < prices.Length; i++)
        {
            prices[i] = (int)averagePrice;
        }

        Console.WriteLine("Final Product Prices:");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine($"Index {i} : {prices[i]}");
        }
        Console.WriteLine("\nTASK 2: BRANCH SALES ANALYSIS");

        Console.Write("Enter number of branches: ");
        int branches = int.Parse(Console.ReadLine());

        Console.Write("Enter number of months: ");
        int months = int.Parse(Console.ReadLine());

        int[,] sales = new int[branches, months];
        int highestSale = 0;

        for (int i = 0; i < branches; i++)
        {
            for (int j = 0; j < months; j++)
            {
                Console.Write($"Enter sales for Branch {i}, Month {j}: ");
                sales[i, j] = int.Parse(Console.ReadLine());

                if (sales[i, j] > highestSale)
                    highestSale = sales[i, j];
            }
        }

        for (int i = 0; i < branches; i++)
        {
            int branchTotal = 0;
            for (int j = 0; j < months; j++)
            {
                branchTotal += sales[i, j];
            }
            Console.WriteLine($"Total sales of Branch {i}: {branchTotal}");
        }

        Console.WriteLine($"Highest Monthly Sale: {highestSale}");
        Console.WriteLine("\nTASK 3: PERFORMANCE BASED JAGGED ARRAY");

        int[][] jaggedSales = new int[branches][];

        for (int i = 0; i < branches; i++)
        {
            int count = 0;

            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= averagePrice)
                    count++;
            }

            jaggedSales[i] = new int[count];
            int index = 0;

            for (int j = 0; j < months; j++)
            {
                if (sales[i, j] >= averagePrice)
                {
                    jaggedSales[i][index] = sales[i, j];
                    index++;
                }
            }
        }

        for (int i = 0; i < jaggedSales.Length; i++)
        {
            Console.Write($"Branch {i}: ");
            for (int j = 0; j < jaggedSales[i].Length; j++)
            {
                Console.Write(jaggedSales[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nTASK 4: CUSTOMER TRANSACTION CLEANING");

        Console.Write("Enter number of customer transactions: ");
        int txnCount = int.Parse(Console.ReadLine());

        List<int> customerList = new List<int>();

        for (int i = 0; i < txnCount; i++)
        {
            Console.Write($"Enter Customer ID {i}: ");
            customerList.Add(int.Parse(Console.ReadLine()));
        }

        HashSet<int> uniqueCustomers = new HashSet<int>(customerList);
        List<int> cleanedList = new List<int>(uniqueCustomers);

        Console.WriteLine("Cleaned Customer List:");
        foreach (int id in cleanedList)
            Console.WriteLine(id);

        Console.WriteLine($"Duplicates Removed: {customerList.Count - cleanedList.Count}");
        Console.WriteLine("\nTASK 5: FINANCIAL TRANSACTION FILTERING");

        Console.Write("Enter number of transactions: ");
        int transCount = int.Parse(Console.ReadLine());

        Dictionary<int, double> transactions = new Dictionary<int, double>();

        for (int i = 0; i < transCount; i++)
        {
            Console.Write("Enter Transaction ID: ");
            int id = int.Parse(Console.ReadLine());

            if (!transactions.ContainsKey(id))
            {
                Console.Write("Enter Amount: ");
                double amount = double.Parse(Console.ReadLine());
                transactions.Add(id, amount);
            }
            else
            {
                Console.WriteLine("Duplicate ID not allowed");
                i--;
            }
        }

        SortedList<int, double> highValueTransactions = new SortedList<int, double>();

        foreach (var item in transactions)
        {
            if (item.Value >= averagePrice)
                highValueTransactions.Add(item.Key, item.Value);
        }

        Console.WriteLine("High Value Transactions:");
        foreach (var item in highValueTransactions)
            Console.WriteLine($"ID: {item.Key}, Amount: {item.Value}");
        Console.WriteLine("\nTASK 6: PROCESS FLOW MANAGEMENT");

        Console.Write("Enter number of operations: ");
        int ops = int.Parse(Console.ReadLine());

        Queue<string> processQueue = new Queue<string>();
        Stack<string> undoStack = new Stack<string>();

        for (int i = 0; i < ops; i++)
        {
            Console.Write($"Enter Operation {i}: ");
            string op = Console.ReadLine();
            processQueue.Enqueue(op);
            undoStack.Push(op);
        }

        Console.WriteLine("Processing Operations:");
        while (processQueue.Count > 0)
        {
            Console.WriteLine(processQueue.Dequeue());
        }

        Console.WriteLine("Undo Operations:");
        for (int i = 0; i < 2 && undoStack.Count > 0; i++)
        {
            Console.WriteLine(undoStack.Pop());
        }


        Console.WriteLine("\nTASK 7: LEGACY DATA RISK DEMONSTRATION");

        Console.Write("Enter number of users: ");
        int users = int.Parse(Console.ReadLine());

        Hashtable userTable = new Hashtable();
        ArrayList mixedList = new ArrayList();

        for (int i = 0; i < users; i++)
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();

            Console.Write("Enter Role: ");
            string role = Console.ReadLine();

            userTable[name] = role;
            mixedList.Add(name);
            mixedList.Add(role);
            mixedList.Add(i); 
        }

        Console.WriteLine("Hashtable Data:");
        foreach (DictionaryEntry item in userTable)
            Console.WriteLine($"{item.Key} : {item.Value}");

        Console.WriteLine("ArrayList Mixed Data:");
        foreach (object obj in mixedList)
            Console.WriteLine(obj);

        Console.WriteLine("Risk: ArrayList allows mixed data types causing runtime errors.");
    }
}
