using KeepingWithAbp.BankAccounts;
using KeepingWithAbp.Branches;
using KeepingWithAbp.Currents;
using KeepingWithAbp.Periods;
using KeepingWithAbp.Safes;
using KeepingWithAbp.SpecialCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Receipts
{
    public class Receipt : FullAuditedAggregateRoot<Guid> // Makbuz
    {
        public ReceiptType ReceiptType { get; set; }
        public string ReceiptNo { get; set; }
        public DateTime Date { get; set; }
        public Guid? CurrentId { get; set; }
        public Guid? SafeId { get; set; }
        public Guid? BankAccountId { get; set; }
        public int NumberOfMoves { get; set; }
        public decimal CheckTotal { get; set; }
        public decimal BondTotal { get; set;}
        public decimal PosTotal { get; set; }
        public decimal CashTotal { get; set; }
        public decimal BankTotal { get; set; }
        public Guid? SpecialCode1Id { get; set; }
        public Guid? SpecialCode2Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid PeriodId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Current Current { get; set; }
        public Safe Safe { get; set; }
        public BankAccount BankAccount { get; set; }
        public SpecialCode SpecialCode1 { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
        public Branch Branch { get; set; }
        public Period Period { get; set; }
        public ICollection<ReceiptTransaction> ReceiptTransactions { get; set; }
    }
}
