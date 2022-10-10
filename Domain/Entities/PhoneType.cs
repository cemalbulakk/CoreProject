using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class PhoneType : BaseEntity
    {
        public int PhoneTypeId { get; set; }
        public string PhoneTypeName { get; set; } = null!;
    }
}
