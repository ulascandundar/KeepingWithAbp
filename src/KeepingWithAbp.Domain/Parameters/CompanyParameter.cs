using KeepingWithAbp.Branches;
using KeepingWithAbp.Periods;
using KeepingWithAbp.Warehouses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace KeepingWithAbp.Parameters
{
    public class CompanyParameter : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public Guid BranchId { get; set; }
        public Guid PeriodId { get; set; }
        public Guid? WareHouseId { get; set; }
        public IdentityUser User { get; set; }
        public Branch Branch { get; set; }
        public Period Period { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}
