using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Labor : BaseEntity
    {
        public int LaborId { get; set; }
        public string LaborName { get; set; } = null!;
        public int LaborTypeId { get; set; }
        public LaborType LaborType { get; set; }
    }
}
