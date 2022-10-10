using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class OperationType : BaseEntity
    {
        public int OperationTypeId { get; set; }
        public string OperationTypeName { get; set; } = null!;
    }
}
