using System;
using System.Collections.Generic;
using System.Linq;

enum TransactionType
{
    Expense,
    Reimbursement
}

class Transaction
{
    public int Id { get; set; }
    public TransactionType Type { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }
    public string VoucherNo { get; set; }
    public string Narration { get; set; }
    public DateTime Date { get; set; }
    public bool Approved { get; set; }
}

class PettyCashFund
{
    public decimal Balance { get; private set; }
    public List<Transaction> Transactions { get; } = new();

    public PettyCashFund(decimal openingBalance)
    {
        Balance = openingBalance;
    }

    public void AddReimbursement(Transaction t)
    {
        t.Approved = true;
        Balance += t.Amount;
        Transactions.Add(t);
    }

    public void AddExpense(Transaction t)
    {
        t.Approved = false; // pending
        Transactions.Add(t);
    }

    public void ApproveExpense(int id)
    {
        var tx = Transactions.FirstOrDefault(t => t.Id == id && !t.Approved);
        if (tx == null)
        {
            Console.WriteLine("Transaction not found or already approved.");
            return;
        }

        if (Balance < tx.Amount)
        {
            Console.WriteLine("Not enough balance!");
            return;
        }

        tx.Approved = true;
        Balance -= tx.Amount;
        Console.WriteLine("Expense Approved ✅");
    }

    public void ShowLedger()
    {
        Console.WriteLine("\n--- Ledger ---");
        foreach (var t in Transactions)
        {
            Console.WriteLine($"{t.Id} | {t.Type} | {t.Category} | {t.Amount} | Approved: {t.Approved}");
        }
        Console.WriteLine("----------------");
    }
}

class Petty
{
    static int idCounter = 1;

   public  static void petty()
    {
        Console.Write("Enter Opening Balance: ");
        decimal opening = decimal.Parse(Console.ReadLine());

        PettyCashFund fund = new PettyCashFund(opening);

        while (true)
        {
            Console.WriteLine("\n==== Petty Cash Manager ====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Add Reimbursement");
            Console.WriteLine("3. Approve Expense");
            Console.WriteLine("4. View Balance");
            Console.WriteLine("5. View Ledger");
            Console.WriteLine("0. Exit");
            Console.Write("Select: ");

            string choice = Console.ReadLine();

            if (choice == "0") break;

            try
            {
                switch (choice)
                {
                    case "1":
                        AddExpense(fund);
                        break;

                    case "2":
                        AddReimbursement(fund);
                        break;

                    case "3":
                        ApproveExpense(fund);
                        break;

                    case "4":
                        Console.WriteLine($"Current Balance: {fund.Balance}");
                        break;

                    case "5":
                        fund.ShowLedger();
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void AddExpense(PettyCashFund fund)
    {
        Console.Write("Category: ");
        string cat = Console.ReadLine();

        Console.Write("Amount: ");
        decimal amt = decimal.Parse(Console.ReadLine());

        Console.Write("Voucher No: ");
        string voucher = Console.ReadLine();

        Console.Write("Narration: ");
        string narr = Console.ReadLine();

        if (amt <= 0) throw new Exception("Amount must be positive");
        if (string.IsNullOrEmpty(voucher)) throw new Exception("Voucher required");

        Transaction t = new Transaction
        {
            Id = idCounter++,
            Type = TransactionType.Expense,
            Category = cat,
            Amount = amt,
            VoucherNo = voucher,
            Narration = narr,
            Date = DateTime.Now,
            Approved = false
        };

        fund.AddExpense(t);
        Console.WriteLine("Expense added (Pending Approval) ⏳");
    }

    static void AddReimbursement(PettyCashFund fund)
    {
        Console.Write("Amount: ");
        decimal amt = decimal.Parse(Console.ReadLine());

        Console.Write("Narration: ");
        string narr = Console.ReadLine();

        if (amt <= 0) throw new Exception("Amount must be positive");

        Transaction t = new Transaction
        {
            Id = idCounter++,
            Type = TransactionType.Reimbursement,
            Category = "Top-Up",
            Amount = amt,
            VoucherNo = "N/A",
            Narration = narr,
            Date = DateTime.Now,
            Approved = true
        };

        fund.AddReimbursement(t);
        Console.WriteLine("Reimbursement Added ✅");
    }

    static void ApproveExpense(PettyCashFund fund)
    {
        Console.Write("Enter Expense ID to approve: ");
        int id = int.Parse(Console.ReadLine());

        fund.ApproveExpense(id);
    }
}