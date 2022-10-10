using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Actor : BaseEntity
    {
        public int ActorId { get; set; }
        public int? ClaimId { get; set; }
        public Claim Claim { get; set; }
        public int? ActorTypeId { get; set; }
        public ActorType ActorType { get; set; }
        public int? TenantId { get; set; }
        public Tenant Tenant { get; set; }
        public string? ActorName { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public DateTime? RequestDate { get; set; }
    }
}
