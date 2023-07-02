using System;
using System.Collections.Generic;
using System.Text;

namespace KeepingWithAbp.Receipts
{
    public enum DocumentStatusType
    {
        InPortfolio = 1,
        Payable = 2,
        Endorsed = 3,
        Collected = 4,
        Paid = 5
    }
}
