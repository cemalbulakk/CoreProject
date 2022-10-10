using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DamageType : BaseEntity
    {
        public int DamageTypeId { get; set; }
        public string DamageTypeCode { get; set; } = null!;
        public string Sbmcode { get; set; } = null!;
        public string DamageTypeName { get; set; } = null!;
    }
}
