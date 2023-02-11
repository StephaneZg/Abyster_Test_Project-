
using System.ComponentModel.DataAnnotations.Schema;
using Abyster_Test_Project.Domain.Accounts;
using Abyster_Test_Project.SharedKernel;

namespace Abyster_Test_Project.Domain.Account_Journals;

public class AccountJournal : Common {

    public Double amount {get; set; }

    public Double balanceBefore {get; set; }

    public Double balanceAfter {get; set; }

    [ForeignKey(name: "account_id")]
    public Account account {get; set; }
}