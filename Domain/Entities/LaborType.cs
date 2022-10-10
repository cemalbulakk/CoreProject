using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class LaborType : BaseEntity
    {
        public int LaborTypeId { get; set; }
        public string LaborTypeName { get; set; } = null!;
    }
}
