using System;

class Wallet
{
    private double money;

    // Constru
    public Wallet(double initialMoney)
    {
        money = initialMoney;
    }

    // Add money to the wallet
    public void AddMoney(double amt)
    {
        money = money + amt;
    }

    // Return current balance
    public double GetBalance()
    {
        return money;
    }
}

// main method
class Wall
{
    public static void Wallet()
    {
        Wallet wallet = new Wallet(500);

        wallet.AddMoney(200);
       

        Console.WriteLine("Wallet Balance: " + wallet.GetBalance());
    }
}
