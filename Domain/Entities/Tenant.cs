using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Tenant : BaseEntity
    {
        public int TenantId { get; set; }
        public string TenantName { get; set; } = null!;
        public string TenantTitle { get; set; } = null!;
        public string TenantWeb { get; set; } = null!;

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
