using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ClaimSparePartActor : BaseEntity
    {
        public int ClaimSparePartActorId { get; set; }
        public int? SparePartId { get; set; }
        public int? ClaimId { get; set; }
        public int? ActorTypeId { get; set; }
        public int? ActorId { get; set; }
        public int? OrderId { get; set; }
    }
}
