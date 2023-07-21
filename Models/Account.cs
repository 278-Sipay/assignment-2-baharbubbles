namespace Assigment2.Models;
public class Account
{
    public int AccountNumber { get; set; }
    public int AmountCredit { get; set; }
    public int AmountDebit { get; set; }
    public string? Description { get; set; }
    public DateTime TransactionDate { get; set; }
    public int ReferenceNumber { get; set; }
}