using KeepingWithAbp.Branches;
using KeepingWithAbp.Currents;
using KeepingWithAbp.Periods;
using KeepingWithAbp.SpecialCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Bills
{
    public class Bill : FullAuditedAggregateRoot<Guid>
    {
        public BillType BillType { get; set; }
        public string BillNo { get; set; }
        public DateTime Date { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ExcludesVat { get; set; }
        public decimal VatAmount { get; set; }
        public decimal NetAmount { get; set; }
        public int NumberOfMoves { get; set; }
        public Guid CurrentId { get; set; }
        public Guid? SpecialCode1Id { get; set; }
        public Guid? SpecialCode2Id { get; set; }
        public Guid BranchId { get; set; }
        public Guid PeriodId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Current Current { get; set; }
        public SpecialCode SpecialCode1 { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
        public Branch Branch { get; set; }
        public Period Period { get; set; }
        public ICollection<BillTransaction> BillTransactions { get; set; }
    }
}
