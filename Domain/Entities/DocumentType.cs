using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DocumentType : BaseEntity
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
    }
}
