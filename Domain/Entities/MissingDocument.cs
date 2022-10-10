using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class MissingDocument : BaseEntity
    {
        public int MissingDocumentId { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public string Description { get; set; } = null!;
        public int EmailId { get; set; }
        public Email Email { get; set; }
        public DateTime MissingDocumentDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
