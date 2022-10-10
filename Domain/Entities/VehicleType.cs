using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VehicleType : BaseEntity
    {
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; } = null!;
    }
}
