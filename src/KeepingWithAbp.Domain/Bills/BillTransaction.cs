using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepingWithAbp.BillTransactions;
using KeepingWithAbp.Expenses;
using KeepingWithAbp.Labors;
using KeepingWithAbp.Stocks;
using KeepingWithAbp.Warehouses;
using Volo.Abp.Domain.Entities.Auditing;

namespace KeepingWithAbp.Bills
{
    public class BillTransaction : FullAuditedEntity<Guid>
    {
        public Guid BillId { get; set; }
        public BillTransactionType BillTransactionType { get; set; }
        public Guid? StockId { get; set; }
        public Guid? LaborId { get; set; }
        public Guid? ExpenseId { get; set; }
        public Guid? WareHouseId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal DiscountPrice { get; set; }
        public int VatRate { get; set; }
        public decimal ExcludesVat { get; set; }
        public decimal VatPrice { get; set; }
        public decimal NetPrice { get; set; }
        public string Description { get; set; }
        public Bill Bill { get; set; }
        public Stock Stock { get; set; }
        public Labor Labor { get; set; }
        public Expense Expense { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
