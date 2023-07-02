using KeepingWithAbp.BankAccounts;
using KeepingWithAbp.BankBranches;
using KeepingWithAbp.Banks;
using KeepingWithAbp.Safes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Receipts
{
    public class ReceiptTransaction : FullAuditedEntity<Guid>
    {
        public Guid ReceiptId { get; set; }
        public PaymentType PaymentType { get; set; }
        public int TrackingNo { get; set; }
        public Guid? CheckBankId { get; set; }
        public Guid? CheckBankBranchId { get; set; }
        public string ChechAccountNo { get; set; }
        public string DocumentNo { get; set; }
        public DateTime Date { get; set; }
        public string PrincipalDebtor { get; set; }
        public string Endorser { get; set; }
        public Guid? SafeId { get; set; }
        public Guid? BankAccountId { get; set; }
        public decimal Price { get; set; }
        public DocumentStatusType DocumentStatusType { get; set; }
        public bool OurOwnCocument { get; set; }
        public string Description { get; set; }
        public Receipt Receipt { get; set; }
        public Bank CheckBank { get; set; }
        public BankBranch CheckBankBranch { get; set; }
        public Safe Safe { get; set; }
        public BankAccount BankAccount { get; set; }

    }
}
