using Microsoft.AspNetCore.Mvc;
using Assigment2.Models;
using Assigment2.Repositories;
using System.Linq.Expressions;
using Assigment2.Schema;

namespace Assigment2.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ILogger<TransactionController> _logger;
    private readonly IAccountRepository _accountRepository;

    public TransactionController(ILogger<TransactionController> logger, IAccountRepository accountRepository)
    {
        _logger = logger;
        _accountRepository = accountRepository;
    }
    [HttpGet("GetByParameter")]
    public List<Account> Get([FromQuery] AccountRequest filter)
    {
        return _accountRepository.Filter(filter);
    }
    // ([FromQuery]int AccountNumber, [FromQuery]int MinAmountCredit, [FromQuery]int MaxAmountCredit, [FromQuery]int MinAmountDebit, [FromQuery]int MaxAmountDebit, [FromQuery]string Description, [FromQuery]DateTime BeginDate,    [FromQuery]DateTime EndDate, [FromQuery]int ReferenceNumber)
}
