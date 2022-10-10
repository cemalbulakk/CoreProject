using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class UserType : BaseEntity
    {
        public int UserTypeId { get; set; }
        public string? UserTypeName { get; set; }
    }
}
