using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DocumentStatus : BaseEntity
    {
        public int DocumentStatusId { get; set; }
        public string DocumentStatusName { get; set; } = null!;
    }
}
