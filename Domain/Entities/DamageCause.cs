using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DamageCause : BaseEntity
    {
        public int DamageCauseId { get; set; }
        public string? DamageCauseCode { get; set; }
        public int? BranchId { get; set; }
        public string? Sbmcode { get; set; }
        public string? DamageCauseName { get; set; }
        public string? GuaranteeCode { get; set; }
        
    }
}
