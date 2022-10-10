using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class SparePart : BaseEntity
    {
        public int SparePartId { get; set; }
        public string SparePartCode { get; set; } = null!;
        public string SparePartName { get; set; } = null!;
        public int SparePartTypeId { get; set; }
        public SparePartType SparePartType { get; set; }
    }
}
