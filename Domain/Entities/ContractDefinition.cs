using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ContractDefinition : BaseEntity
    {
        public int ContractDefinitionId { get; set; }
        public string Definition { get; set; } = null!;
    }
}
