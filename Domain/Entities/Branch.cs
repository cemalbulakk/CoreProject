using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Branch : BaseEntity
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; } = null!;
        public string Sbmcode { get; set; } = null!;
    }
}
