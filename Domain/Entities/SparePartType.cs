using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SparePartType : BaseEntity
    {
        public int SparePartTypeId { get; set; }
        public string SparePartTypeName { get; set; } = null!;
    }
}
