using KeepingWithAbp.Bills;
using KeepingWithAbp.Receipts;
using KeepingWithAbp.SpecialCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Currents
{
    public class Current : FullAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNo { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public Guid? SpecialCode1Id { get; set; }
        public Guid? SpecialCode2Id { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public SpecialCode SpecialCode1 { get; set; }
        public SpecialCode SpecialCode2 { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
