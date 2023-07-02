using System;
using System.Collections.Generic;
using System.Text;

namespace KeepingWithAbp.BankAccounts
{
    public enum BankAccountType
    {
        DemandDepositAccount = 1,
        TimeDepositAccount = 2,
        CreditAccount = 3,
        PosBlockedAccount = 4,
        FundAccount = 5,
        InvestmentAccount = 6
    }
}
