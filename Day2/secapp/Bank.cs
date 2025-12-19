using System;

class Debit
{
    public void ATMWithdrawal()
    {
        Console.Write("Enter withdrawal amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        if (amount <= 40000)
            Console.WriteLine("Withdrawal permitted within daily limit.");
        else
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
    }

    public void EMICheck()
    {
        Console.Write("Enter monthly income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter EMI amount: ");
        double emi = Convert.ToDouble(Console.ReadLine());

        if (emi <= income * 0.40)
            Console.WriteLine("EMI is financially manageable.");
        else
            Console.WriteLine("EMI exceeds safe income limit.");
    }

    public void DailySpending()
    {
        Console.Write("Enter number of transactions: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double total = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter amount for transaction {i}: ");
            total += Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Total debit amount for the day: ₹" + total);
    }

    public void MinimumBalance()
    {
        Console.Write("Enter current balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        if (balance < 2000)
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        else
            Console.WriteLine("Minimum balance requirement satisfied.");
    }
}

class Credit
{
    public void NetSalary()
    {
        Console.Write("Enter gross salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        double netSalary = salary - (salary * 0.10);
        Console.WriteLine("Net salary credited: ₹" + netSalary);
    }

    public void FDMaturity()
    {
        Console.Write("Enter principal amount: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (years): ");
        double t = Convert.ToDouble(Console.ReadLine());

        double interest = (p * r * t) / 100;
        double maturity = p + interest;

        Console.WriteLine("Fixed Deposit maturity amount: ₹" + maturity);
    }

    public void RewardPoints()
    {
        Console.Write("Enter total credit card spending: ");
        int spending = Convert.ToInt32(Console.ReadLine());

        int points = spending / 100;
        Console.WriteLine("Reward points earned: " + points);
    }

    public void BonusEligibility()
    {
        Console.Write("Enter annual salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (salary >= 500000 && years >= 3)
            Console.WriteLine("Employee is eligible for bonus.");
        else
            Console.WriteLine("Employee is not eligible for bonus.");
    }
}

class Ban
{
    public static void Bank()
    {
        Debit debit = new Debit();
        Credit credit = new Credit();

        while (true)
        {
            Console.WriteLine("\n--- Finance Management System ---");
            Console.WriteLine("1. Debit Operations");

            Console.WriteLine("2. Credit perations");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nDebit Menu");
                    Console.WriteLine("1. ATM Withdrawal");
                    Console.WriteLine("2. EMI Check");
                    Console.WriteLine("3. Daily Spending");
                    Console.WriteLine("4. Minimum Balance");
                    Console.Write("Choose option: ");

                    int d = Convert.ToInt32(Console.ReadLine());

                    switch (d)
                    {
                        case 1: debit.ATMWithdrawal(); break;
                        case 2: debit.EMICheck(); break;
                        case 3: debit.DailySpending(); break;
                        case 4: debit.MinimumBalance(); break;
                        default: Console.WriteLine("Invalid Debit Option"); break;
                    }
                    break;

                case 2:
                    Console.WriteLine("\nCredit Menu");
                    Console.WriteLine("1. Net Salary");
                    Console.WriteLine("2. FD Maturity");
                    Console.WriteLine("3. Reward Points");
                    Console.WriteLine("4. Bonus Eligibility");
                    Console.Write("Choose option: ");

                    int c = Convert.ToInt32(Console.ReadLine());

                    switch (c)
                    {
                        case 1: credit.NetSalary(); break;
                        case 2: credit.FDMaturity(); break;
                        case 3: credit.RewardPoints(); break;
                        case 4: credit.BonusEligibility(); break;
                        default: Console.WriteLine("Invalid Credit Option"); break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank you! Program exited.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
