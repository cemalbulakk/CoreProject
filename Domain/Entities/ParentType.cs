using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ParentType : BaseEntity
    {
        public int ParentTypeId { get; set; }
        public string? ParentTypeName { get; set; }
    }
}
