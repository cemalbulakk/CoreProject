using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Contract : BaseEntity
    {
        public int ContractId { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public int ContractParentId { get; set; }
        public int ParentTypeId { get; set; }
        public ParentType ParentType { get; set; }
        public string ContractParentCode { get; set; } = null!;
        public string SourceCode { get; set; } = null!;
        public string BranchCode { get; set; } = null!;
        public bool ContractStatue { get; set; }
        public string OriginalContractUrl { get; set; } = null!;
        public DateTime ContractBeginDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public decimal ContractLimit { get; set; }
        public string Description { get; set; } = null!;
    }
}
