using Assigment2.Models;
using Assigment2.Schema;
using System.Linq;
using System.Linq.Expressions;

namespace Assigment2.Repositories;
public interface IAccountRepository
{
    public List<Account> Filter(AccountRequest filter);

}
public class AccountRepository : GenericRepository<Account>, IAccountRepository
{

    public AccountRepository()
    {
        new List<Account>{
        new Account{
            AccountNumber = 1,
            TransactionDate = DateTime.Now.AddDays(-1),
            Description = "1",
            AmountCredit = 12,
            AmountDebit = 4,
            ReferenceNumber = 1001
        },
        new Account{
            AccountNumber = 2,
            TransactionDate = DateTime.Now.AddDays(-4),
            Description = "2",
            AmountCredit = 10,
            AmountDebit = 1,
            ReferenceNumber = 1005
        },
        new Account{
            AccountNumber = 3,
            TransactionDate = DateTime.Now.AddDays(-2),
            Description = "3",
            AmountCredit = 12,
            AmountDebit = 2,
            ReferenceNumber = 1003
        },
        new Account{
            AccountNumber = 4,
            TransactionDate = DateTime.Now.AddDays(-1),
            Description = "4",
            AmountCredit = 7,
            AmountDebit = 4,
            ReferenceNumber = 1007
        },
        new Account{
            AccountNumber = 5,
            TransactionDate = DateTime.Now.AddDays(-6),
            Description = "5",
            AmountCredit = 16,
            AmountDebit = 6,
            ReferenceNumber = 1009
        }
    }.ForEach(item => Add(item));
        
    }
    
    public List<Account> Filter(AccountRequest filter)
    {
        return Where(t => 
        (filter.AccountNumber == 0 || t.AccountNumber == filter.AccountNumber)
        &&
        (filter.MaxAmountCredit == 0 || t.AmountCredit <= filter.MaxAmountCredit)
        &&
        (filter.MinAmountCredit == 0 || t.AmountCredit >= filter.MinAmountCredit)
        &&
        (filter.MaxAmountDebit == 0 || t.AmountDebit <= filter.MaxAmountDebit)
        &&
        (filter.MinAmountDebit == 0 || t.AmountDebit >= filter.MinAmountDebit)
        &&
        (filter.Description == null || t.Description !=null && t.Description.Contains(filter.Description))
        &&
        (filter.BeginDate == null || t.TransactionDate >= filter.BeginDate)
        &&
        (filter.EndDate == null || t.TransactionDate <= filter.EndDate)
        &&
        (filter.ReferenceNumber == 0 || t.ReferenceNumber == filter.ReferenceNumber)
        
        
        );
    }
}