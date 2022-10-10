using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Document : BaseEntity
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; } = null!;
        public string DocumentDescription { get; set; } = null!;
        public string DocumentUrl { get; set; } = null!;
        public int DocumentStatusId { get; set; }
        public DocumentStatus DocumentStatus { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public int RecordTypeId { get; set; }
        public RecordType RecordType { get; set; }
        public int OrderNumber { get; set; }
        public string SbmrevocationCode { get; set; } = null!;
        public int RevocationOrderNumber { get; set; }
    }
}
