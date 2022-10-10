using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ServiceInspectorDocument : BaseEntity
    {
        public int ServiceInspectorDocumentId { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
