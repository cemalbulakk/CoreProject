using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class UserPasswordHistory : BaseEntity
    {
        public int UserPasswordHistoryId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string? UserPasswordHash { get; set; }
    }
}
