using System;

class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

class BankAccount
{
    public decimal Balance { get; private set; } = 5000;

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be greater than zero.");
        }

        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Insufficient balance.");
        }


        Balance -= amount;
        Console.WriteLine("Withdrawal successful. Remaining balance: " + Balance);
    }
}


class Main2
{
   public  static void main2()
    {
        BankAccount account = new BankAccount();

        try
        {
            account.Withdraw(6000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
