using System;

public abstract class Transaction
{
    public Guid Id { get; } = Guid.NewGuid();
    public decimal Amount { get; protected set; }
    public DateTime Date { get; } = DateTime.Now;
    public string Narration { get; protected set; }
    public string Status { get; protected set; } = "Pending";

    protected Transaction(decimal amount, string narration)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero");

        Amount = amount;
        Narration = narration;
    }

    public abstract void Apply(PettyCashFund fund);
}
