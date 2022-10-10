using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class RecordType : BaseEntity
    {
        public int RecordTypeId { get; set; }
        public string RecordTypeName { get; set; } = null!;
    }
}
