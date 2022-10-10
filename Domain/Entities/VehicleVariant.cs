using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VehicleVariant : BaseEntity
    {
        public int VehicleVariantId { get; set; }
        public string VariantNumber { get; set; } = null!;
        public string VariantName { get; set; } = null!;
    }
}
