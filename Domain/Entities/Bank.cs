using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Bank : BaseEntity
    {
        public Bank()
        {
            BankBranches = new HashSet<BankBranch>();
        }

        public int BankId { get; set; }
        public string BankName { get; set; } = null!;

        public virtual ICollection<BankBranch> BankBranches { get; set; }
    }
}
