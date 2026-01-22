public class ReimbursementTransaction : Transaction
{
    public ReimbursementTransaction(decimal amount, string narration)
        : base(amount, narration) { }

    public override void Apply(PettyCashFund fund)
    {
        fund.Balance += Amount;
        Status = "Approved";
    }
}
