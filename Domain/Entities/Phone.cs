using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Phone : BaseEntity
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public int PhoneTypeId { get; set; }
        public int ParentTypeId { get; set; }
        public ParentType ParentType { get; set; }
    }
}
