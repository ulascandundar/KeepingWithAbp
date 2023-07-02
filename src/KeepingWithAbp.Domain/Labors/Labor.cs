using KeepingWithAbp.Bills;
using KeepingWithAbp.SpecialCodes;
using KeepingWithAbp.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Labors
{
    public class Labor : FullAuditedAggregateRoot<Guid> // Hizmet
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int VatRate { get; set; }
        public decimal UnitPrice { get; set; }
        public string Barcode { get; set; }
        public Guid UnitId { get; set; }
        public Guid? SpecialCode1Id { get; set; }
        public Guid? SpecialCode2Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public Unit Unit { get; set; }
        public SpecialCode SpecialCode1 { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
        public ICollection<BillTransaction> BillTransactions { get; set; }

    }
}
