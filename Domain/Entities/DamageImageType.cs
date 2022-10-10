using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DamageImageType : BaseEntity
    {
        public int DamageImageTypeId { get; set; }
        public string DamageImageTypeName { get; set; } = null!;
    }
}
