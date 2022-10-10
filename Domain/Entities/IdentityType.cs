using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class IdentityType : BaseEntity
    {
        public int IdentityTypeId { get; set; }
        public string Sbmcode { get; set; } = null!;
        public string IdentityTypeName { get; set; } = null!;
    }
}
