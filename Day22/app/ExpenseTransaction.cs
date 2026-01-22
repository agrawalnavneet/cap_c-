public class ExpenseTransaction : Transaction
{
    public string VoucherNumber { get; }
    public Category Category { get; }

    public ExpenseTransaction(decimal amount, string narration,
                              string voucher, Category category)
        : base(amount, narration)
    {
        if (string.IsNullOrWhiteSpace(voucher))
            throw new ArgumentException("Voucher number is required");

        VoucherNumber = voucher;
        Category = category;
    }

    public override void Apply(PettyCashFund fund)
    {
        if (fund.Balance < Amount)
            throw new InvalidOperationException("Insufficient balance");

        fund.Balance -= Amount;
        Status = "Approved";
    }
}
