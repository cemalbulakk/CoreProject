using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class AlternativeBrand : BaseEntity
    {
        public int AlternativeBrandId { get; set; }
        public string AlternativeBrandName { get; set; } = null!;
    }
}
