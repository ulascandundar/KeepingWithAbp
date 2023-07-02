using KeepingWithAbp.BankAccounts;
using KeepingWithAbp.BankBranches;
using KeepingWithAbp.Banks;
using KeepingWithAbp.Bills;
using KeepingWithAbp.Currents;
using KeepingWithAbp.Labors;
using KeepingWithAbp.Receipts;
using KeepingWithAbp.Safes;
using KeepingWithAbp.Stocks;
using KeepingWithAbp.Units;
using KeepingWithAbp.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.SpecialCodes
{
    public class SpecialCode : FullAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public SpecialCodeType SpecialCodeType { get; set; }
        public CardType CardType { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public ICollection<BankAccount> SpecialCode1BankAccounts { get; set; }
        public ICollection<BankAccount> SpecialCode2BankAccounts { get; set; }
        public ICollection<Bank> SpecialCode1Banks { get; set; }
        public ICollection<Bank> SpecialCode2Banks { get; set; }
        public ICollection<BankBranch> SpecialCode1BankBranches { get; set; }
        public ICollection<BankBranch> SpecialCode2BankBranches { get; set; }
        public ICollection<Unit> SpecialCode1Units { get; set; }
        public ICollection<Unit> SpecialCode2Units { get; set; }
        public ICollection<Current> SpecialCode1Currents { get; set; }
        public ICollection<Current> SpecialCode2Currents { get; set; }
        public ICollection<Warehouse> SpecialCode1Warehouses { get; set; }
        public ICollection<Warehouse> SpecialCode2Warehouses { get; set; }
        public ICollection<Bill> SpecialCode1Bills { get; set; }
        public ICollection<Bill> SpecialCode2Bills { get; set; }
        public ICollection<Labor> SpecialCode1Labors { get; set; }
        public ICollection<Labor> SpecialCode2Labors { get; set; }
        public ICollection<Safe> SpecialCode1Safes { get; set; }
        public ICollection<Safe> SpecialCode2Safes { get; set; }
        public ICollection<Receipt> SpecialCode1Receipts { get; set; }
        public ICollection<Receipt> SpecialCode2Receipts { get; set; }
        public ICollection<Stock> SpecialCode1Stocks { get; set; }
        public ICollection<Stock> SpecialCode2Stocks { get; set; }
        public ICollection<Stock> SpecialCode1Expenses { get; set; }
        public ICollection<Stock> SpecialCode2Expenses { get; set; }
    }
}
