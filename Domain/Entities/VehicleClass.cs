using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VehicleClass : BaseEntity
    {
        public int VehicleClassId { get; set; }
        public string VehicleClassName { get; set; } = null!;
        public string VehicleClassCode { get; set; } = null!;
    }
}
