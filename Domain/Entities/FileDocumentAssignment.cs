using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FileDocumentAssignment : BaseEntity
    {
        public int FileDocumentAssignmentId { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
        public string Note { get; set; } = null!;
    }
}
