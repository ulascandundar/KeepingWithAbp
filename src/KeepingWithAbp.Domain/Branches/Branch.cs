using KeepingWithAbp.BankAccounts;
using KeepingWithAbp.Bills;
using KeepingWithAbp.Parameters;
using KeepingWithAbp.Receipts;
using KeepingWithAbp.Safes;
using KeepingWithAbp.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Branches
{
    public class Branch : FullAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
        public ICollection<Warehouse> Warehouses { get; set; }
        public ICollection<Bill> Bills { get; set; }
        public ICollection<Safe> Safes { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
        public ICollection<CompanyParameter> CompanyParameters { get; set; }
    }
}
