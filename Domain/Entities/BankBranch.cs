using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class BankBranch : BaseEntity
    {
        public int BankBranchId { get; set; }
        public string BankBranchName { get; set; } = null!;
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; } = null!;
    }
}
