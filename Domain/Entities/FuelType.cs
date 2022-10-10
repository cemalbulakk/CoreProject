using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FuelType : BaseEntity
    {
        public int FuelTypeId { get; set; }
        public string FuelTypeName { get; set; } = null!;
    }
}
