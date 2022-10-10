using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ReturnStatusType : BaseEntity
    {
        public int ReturnStatusTypeId { get; set; }
        public string ReturnStatusTypeName { get; set; } = null!;
    }
}
