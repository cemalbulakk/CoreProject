using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class BranchDocumentAssignment : BaseEntity
    {
        public int BranchDocumentAssignmentId { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
