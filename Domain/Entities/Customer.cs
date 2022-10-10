using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Customer : BaseEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerCode { get; set; } = null!;
        public int TenantId { get; set; }
        public Tenant Tenant { get; set; }
    }
}
