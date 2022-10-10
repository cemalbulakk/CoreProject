using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Email : BaseEntity
    {
        public int EmailId { get; set; }
        public int EmailParentId { get; set; }
        public int ParentTypeId { get; set; }
        public ParentType ParentType { get; set; }
        public string EmailValue { get; set; } = null!;
    }
}
