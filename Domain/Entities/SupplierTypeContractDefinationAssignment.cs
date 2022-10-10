using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SupplierTypeContractDefinationAssignment : BaseEntity
    {
        public int SupplierTypeContractDefinationAssignmentId { get; set; }
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public int ContractDefinitionId { get; set; }
        public ContractDefinition ContractDefinition { get; set; }
        public int SupplierTypeId { get; set; }
        public SupplierType SupplierType { get; set; }
    }
}
