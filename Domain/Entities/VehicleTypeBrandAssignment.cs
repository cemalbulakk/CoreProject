using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VehicleTypeBrandAssignment : BaseEntity
    {
        public int VehicleTypeBrandAssignmentId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public string Sbmcode { get; set; } = null!;
    }
}
