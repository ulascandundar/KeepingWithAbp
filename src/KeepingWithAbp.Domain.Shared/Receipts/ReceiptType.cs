using System;
using System.Collections.Generic;
using System.Text;

namespace KeepingWithAbp.Receipts
{
    public enum ReceiptType
    {
        Collection = 1,
        Payment = 2,
        SafeTransaction = 3,
        BankTransaction = 4
    }
}
