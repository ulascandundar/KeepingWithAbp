using KeepingWithAbp.Branches;
using KeepingWithAbp.Receipts;
using KeepingWithAbp.SpecialCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Safes
{
    public class Safe : FullAuditedAggregateRoot<Guid> // Kasa
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? SpecialCode1Id { get; set; }
        public Guid? SpecialCode2Id { get; set; }
        public Guid BranchId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public SpecialCode SpecialCode1 { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
        public ICollection<ReceiptTransaction> ReceiptTransactions { get; set; }
    }
}
