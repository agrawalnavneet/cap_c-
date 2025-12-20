using System;

class Account
{
    private double balance;

    public Account(double initialBalance)
    {
        this.balance = initialBalance;
    }

    // double +double
    public double Deposit(double value1, double value2)
    {
        balance += value1 + value2;
        return balance;
    }

    // int + int
    public double Deposit(int value1, int value2)
    {
        return Deposit((double)value1, (double)value2);
    }

    // double + int
    public double Deposit(double value1, int value2)
    {
        return Deposit(value1, (double)value2);
    }

    // int + double
    public double Deposit(int value1, double value2)
    {
        return Deposit((double)value1, value2);
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Over
{
    public static void Overload()
    {
        Account account = new Account(1000);

        Console.WriteLine(account.Deposit(10.531, 1300.145));
        Console.WriteLine(account.Deposit(300, 10300));
        Console.WriteLine(account.Deposit(10, 1003.61));

        Console.WriteLine("Final Balance: " + account.GetBalance());
    }
}
