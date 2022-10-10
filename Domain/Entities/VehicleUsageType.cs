using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class VehicleUsageType : BaseEntity
    {
        public int VehicleUsageTypeId { get; set; }
        public string? OtherCode { get; set; }
        public string? VehicleUsageTypeCode { get; set; }
        public string? VehicleUsageTypeName { get; set; }
    }
}
