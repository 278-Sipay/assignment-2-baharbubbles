namespace Assigment2.Schema;

public class AccountRequest
{
    public int AccountNumber { get; set; }
    public int MinAmountCredit { get; set; }
    public int MaxAmountCredit { get; set; }
    public int MinAmountDebit { get; set; }
    public int MaxAmountDebit { get; set; }
    public string? Description { get; set; }
    public DateTime? BeginDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int ReferenceNumber { get; set; }
}