using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SupplierWorkType : BaseEntity
    {
        public int SupplierWorkTypeId { get; set; }
        public string SupplierWorkTypeName { get; set; } = null!;
    }
}
