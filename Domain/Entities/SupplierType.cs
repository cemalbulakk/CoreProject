using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SupplierType : BaseEntity
    {
        public int SupplierTypeId { get; set; }
        public string SupplierTypeName { get; set; } = null!;
    }
}
