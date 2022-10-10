using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class TenderPoolDocument : BaseEntity
    {
        public int TenderPoolDocumentId { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public bool Transferred { get; set; }
    }
}
