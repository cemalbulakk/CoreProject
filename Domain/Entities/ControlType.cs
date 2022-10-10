using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ControlType : BaseEntity
    {
        public int ControlTypeId { get; set; }
        public string ControlTypeName { get; set; } = null!;
    }
}
