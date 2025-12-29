using System;

namespace QuickMartTraders
{
    public class SaleTransaction
    {
        public string? InvoiceNo;
        public string? CustomerName;
        public string? ItemName;

        public int Quantity;
        public decimal PurchaseAmount;
        public decimal SellingAmount;

        public string? ProfitOrLossStatus;
        public decimal ProfitOrLossAmount;
        public decimal ProfitMarginPercent;
    }
    public class SaleTransactionManager
    {
        public static SaleTransaction? LastTransaction;
        public static bool HasLastTransaction = false;
        public static void CreateTransaction()
        {
            SaleTransaction transaction = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            transaction.InvoiceNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(transaction.InvoiceNo))
            {
                Console.WriteLine("Invoice No cannot be empty.");
                return;
            }

            Console.Write("Enter Customer Name: ");
            transaction.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            transaction.ItemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out transaction.Quantity) || transaction.Quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0.");
                return;
            }

            Console.Write("Enter Purchase Amount: ");
            if (!decimal.TryParse(Console.ReadLine(), out transaction.PurchaseAmount) || transaction.PurchaseAmount <= 0)
            {
                Console.WriteLine("Purchase Amount must be greater than 0.");
                return;
            }

            Console.Write("Enter Selling Amount: ");
            if (!decimal.TryParse(Console.ReadLine(), out transaction.SellingAmount) || transaction.SellingAmount < 0)
            {
                Console.WriteLine("Selling Amount must be 0 or greater.");
                return;
            }

            CalculateProfitLoss(transaction);

            LastTransaction = transaction;
            HasLastTransaction = true;

            Console.WriteLine("\nTransaction saved successfully.");
            PrintCalculation(transaction);
        }
        public static void ViewLastTransaction()
        {
            if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available.");
                return;
            }

            SaleTransaction t = LastTransaction;

            Console.WriteLine("\n------------ Last Transaction ------------");
            Console.WriteLine($"Invoice No : {t.InvoiceNo}");
            Console.WriteLine($"Customer   : {t.CustomerName}");
            Console.WriteLine($"Item       : {t.ItemName}");
            Console.WriteLine($"Quantity   : {t.Quantity}");
            Console.WriteLine($"Purchase   : {t.PurchaseAmount}");
            Console.WriteLine($"Selling    : {t.SellingAmount}");
            Console.WriteLine($"Status     : {t.ProfitOrLossStatus}");
            Console.WriteLine($"Amount     : {t.ProfitOrLossAmount}");
            Console.WriteLine($"Margin %   : {t.ProfitMarginPercent}");
            Console.WriteLine("------------------------------------------");
        }
        public static void RecalculateProfitLoss()
        {
            if (!HasLastTransaction || LastTransaction == null)
            {
                Console.WriteLine("No transaction available.");
                return;
            }

            CalculateProfitLoss(LastTransaction);
            PrintCalculation(LastTransaction);
        }
        private static void CalculateProfitLoss(SaleTransaction t)
        {
            if (t.SellingAmount > t.PurchaseAmount)
            {
                t.ProfitOrLossStatus = "PROFIT";
                t.ProfitOrLossAmount = t.SellingAmount - t.PurchaseAmount;
            }
            else if (t.SellingAmount < t.PurchaseAmount)
            {
                t.ProfitOrLossStatus = "LOSS";
                t.ProfitOrLossAmount = t.PurchaseAmount - t.SellingAmount;
            }
            else
            {
                t.ProfitOrLossStatus = "BREAK EVEN";
                t.ProfitOrLossAmount = 0;
            }

            t.ProfitMarginPercent = (t.ProfitOrLossAmount / t.PurchaseAmount) * 100;
        }

        private static void PrintCalculation(SaleTransaction t)
        {
            Console.WriteLine($"Status: {t.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {t.ProfitOrLossAmount}");
            Console.WriteLine($"Profit Margin (%): {t.ProfitMarginPercent}");
        }
    }

    class Funct2
    {
        public static void Run()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n========= QuickMart Traders =========");
                Console.WriteLine("1. Create New Transaction");
                Console.WriteLine("2. View Last Transaction");
                Console.WriteLine("3. Recalculate Profit/Loss");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SaleTransactionManager.CreateTransaction();
                        break;

                    case "2":
                        SaleTransactionManager.ViewLastTransaction();
                        break;

                    case "3":
                        SaleTransactionManager.RecalculateProfitLoss();
                        break;

                    case "4":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }

   
    
   
}
